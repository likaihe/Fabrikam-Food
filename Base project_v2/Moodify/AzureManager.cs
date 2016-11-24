using Microsoft.WindowsAzure.MobileServices;
using Moodify.DataModels;
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
        private IMobileServiceTable<Timeline> timelineTable;
        private IMobileServiceTable<Menu> menuTable;
       private IMobileServiceTable<OrderList> orderListTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("https://likaifabrikamfood.azurewebsites.net");
            this.timelineTable = this.client.GetTable<Timeline>();
           this.menuTable = this.client.GetTable<Menu>();
            this.orderListTable = this.client.GetTable<OrderList>();
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

        //Post the DATA
        public async Task AddTimeline(Timeline timeline)
        {
            await this.timelineTable.InsertAsync(timeline);
        }

        public async Task AddOder(OrderList order)
        {
            await this.orderListTable.InsertAsync(order);
        }

        //Get the data
        public async Task<List<Timeline>> GetTimelines()
        {
            return await this.timelineTable.ToListAsync();
        }

        public async Task<List<OrderList>> GetOrderList()
        {
            return await this.orderListTable.ToListAsync();
        }

        public async Task<List<Menu>> GetMenus()
        {
            return await this.menuTable.ToListAsync();
        }

        //Delete the data
        public async Task DeleteOderList(OrderList orderList)
        {
            await this.orderListTable.DeleteAsync(orderList);
        }

    }
}
