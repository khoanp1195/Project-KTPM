using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using ProjectKTPM.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKTPM.BUS
{
    class AccountBUS
    {
        static IFirebaseConfig config = new FirebaseConfig 
        { BasePath = "https://gamecaro-6dbb7-default-rtdb.asia-southeast1.firebasedatabase.app/" };

        static FirebaseClient client = new FirebaseClient(config);

        public bool AddNew(User newAccount)
        {
            try
            {
                client.Set("accountss/" + newAccount.Username, newAccount); // auto -generated key
                return true;
            }
            catch { return false; }
        }


        public bool CheckAccount(User account)
        {
            FirebaseResponse response = client.Get("accountss");
            Dictionary<String, Account> dicAccounts = response.ResultAs<Dictionary<String, Account>>();
            String key = dicAccounts.FirstOrDefault(x => x.Value.username == account.Username && x.Value.password == account.Password).Key;
            //(x => x.Value.userid == account.userid && x.Value.name == account.name && x.Value.gender == account.gender && x.Value.dob == account.dob && x.Value.address == account.address && x.Value.education == account.education && x.Value.username == account.username && x.Value.password == account.password).Key;
            if (String.IsNullOrEmpty(key)) return false;
            return true;
        }


        private void UpdateDataGridView(DataGridView gvAccount)
        {
            List<User> planes = GetAll();
            gvAccount.BeginInvoke(new MethodInvoker(delegate
            {
                gvAccount.DataSource = planes;
            })); // set asynchronous datasource

        }


        public async void ListenFirebase(DataGridView gvPlane)
        {
            EventStreamResponse response = await client.OnAsync("accountss",
               added: (sender, args, context) => { UpdateDataGridView(gvPlane); },
               changed: (sender, args, context) => { UpdateDataGridView(gvPlane); },
               removed: (sender, args, context) => { UpdateDataGridView(gvPlane); }
          );

        }

        public List<User> GetAll()
        {
            FirebaseResponse response = client.Get("accountss");
            Dictionary<String, User> dictBooks = response.ResultAs<Dictionary<String, User>>();
            return dictBooks.Values.ToList();
        }

        public User GetDetails(int Mssv)
        {
            FirebaseResponse response = client.Get("accountss/" + Mssv);
            User user = response.ResultAs<User>();

            return user;

        }


        private String GetKeyByCode(int Mssv)
        {
            FirebaseResponse response = client.Get("accountss");
            Dictionary<String, User> dictPlanes = response.ResultAs<Dictionary<String, User>>();
            String key = dictPlanes.FirstOrDefault(x => x.Value.Mssv == Mssv).Key;
            return key;


        }

        public List<User> Search(String keyword)
        {
            List<User> planes = new List<User>();
            foreach (var item in GetAll())
            {
                if (item.Name.ToLower().Contains(keyword.ToLower()))
                {
                    planes.Add(item);
                }

            }
            return planes;

        }


        public bool Update(User newUser)
        {
            try
            {
                String key = GetKeyByCode(newUser.Mssv);
                if (String.IsNullOrEmpty(key))
                    return false;
                client.Set("accountss/" + key, newUser);

                return true;


            }
            catch { return false; }
        }




        public bool Delete(int Mssv)
        {
            try
            {
                String key = GetKeyByCode(Mssv);
                if (String.IsNullOrEmpty(key)) return false;
                client.Delete("accountss/" + key);

                return true;
            }
            catch { return false; }
        }



    }

}


