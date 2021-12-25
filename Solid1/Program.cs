using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    // Порушено Single Responsbility Principle
    class Item
    {
        public void AddItem() {/*...*/}
        public void DeleteItem() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
    }
    class DisplayOrder
    {
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}

    }
    class OrdersDB
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
    }
    class Order
    {
        public void CalculateTotalSum() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
