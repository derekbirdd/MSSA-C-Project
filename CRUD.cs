using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    interface CRUD
    {
        ICollection<Inventory> GetInventory();
       
        void AddProduct(Inventory obj);
        void RemoveProduct(Inventory obj);
        void UpdateInventory(int id, Inventory stockchanges);

    }
    class StoreInventory : CRUD
    {
        ProductInventoryEntities entity;
        public StoreInventory()
        {
            entity = new ProductInventoryEntities(); 
        }
        public void AddProduct(Inventory obj)
        {
            entity.Inventories.Add(obj);
            entity.SaveChanges();
        }

        public ICollection<Inventory> GetInventory()
        {
            return entity.Inventories.ToList();
        }

        public void RemoveProduct(Inventory obj)
        {
            entity.Inventories.Remove(obj);
            entity.SaveChanges();
        }

        public void UpdateInventory(int id, Inventory stockchanges)
        {
            var prodtoupdate = entity.Inventories.Find(id);
            prodtoupdate.ProductID = stockchanges.ProductID;
            prodtoupdate.Name = stockchanges.Name;
            prodtoupdate.Color = stockchanges.Color;
            prodtoupdate.Cost = stockchanges.Cost;
            prodtoupdate.Size = stockchanges.Size;
            entity.SaveChanges();

        }
        public Inventory FindProd(int ID)
        {
            var prod = entity.Inventories.First(n => n.ProductID == ID);
            if (prod != null)
            {
                return prod;
            }
            return null;
        }
    }
}
