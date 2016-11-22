using Microsoft.WindowsAzure.MobileServices;
using Moodify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify
{
    public class AzureManager
    {

        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable menu;



        private AzureManager()
        {
            this.client = new MobileServiceClient("http://likaifabrikamfood.azurewebsites.net");
            //create a table reference
            this.menu = this.client.GetTable<Menu>();   
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        //public async Task<List<Menu>> GetMenus()
        //{
        //   // return await this.menu.ToString();
        //}

    }
}
