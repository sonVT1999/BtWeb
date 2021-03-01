using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelBooking.Models;

namespace HotelBooking.ViewModels
{
    [Serializable]
    public class CartItem
    {
        public RoomViewForCartModel Room { get; set; }
        public int Quantity { set; get; }
        public DateTime ngayden { get; set; }
        public DateTime ngaydi { get; set; }
    }

    public class Cart
    {
        private List<CartItem> lineCollection = new List<CartItem>();
        
        public void AddItem(RoomViewForCartModel sp, int quantity)
        {
            CartItem line = lineCollection
                .Where(p => p.Room.Id_Room == sp.Id_Room)
                .FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartItem
                {
                    Room = sp,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
                if (line.Quantity <= 0)
                {
                    lineCollection.RemoveAll(l => l.Room.Id_Room == sp.Id_Room);
                }
            }
        }
        public void UpdateItem(RoomViewForCartModel sp, int quantity)
        {
            CartItem line = lineCollection
                .Where(p => p.Room.Id_Room == sp.Id_Room)
                .FirstOrDefault();

            if (line != null)
            {
                if (quantity > 0)
                {
                    line.Quantity = quantity;
                }
                else
                {
                    lineCollection.RemoveAll(l => l.Room.Id_Room == sp.Id_Room);
                }
            }
        }
        public void RemoveLine(RoomViewForCartModel sp)
        {
            lineCollection.RemoveAll(l => l.Room.Id_Room == sp.Id_Room);
        }

        public int? ComputeTotalValue()
        {
            return lineCollection.Sum(e => Convert.ToInt32(e.Room.Price) * e.Quantity);

        }
        public int? ComputeTotalProduct()
        {
            return lineCollection.Sum(e => e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartItem> Lines
        {
            get { return lineCollection; }
        }
    }
}