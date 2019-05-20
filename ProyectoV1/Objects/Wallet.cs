using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.People;
using ProyectoV1.Exceptions;
using System.Windows.Forms;

namespace ProyectoV1.Objects
{
    public static class Wallet
    {
        public static int cash = 100;

        public static void findMoney(Money x)
        {
            cash += x.getQuantity();
        }

        public static void buyItems(Items item, Characters player)
        {
            try
            {
                if (cash >= item.getPrice() && item.canBeSold() == true)
                {
                    cash -= item.getPrice();
                    Inventory.addItem(item, player);
                }
                else
                {
                    throw new ItemNotSellable();
                }
            }
            catch
            {
                MessageBox.Show("Item couldn't be bought. Please make sure item is a weapon or a med.");
            }
        }

        public static void sellItems(Items item, Characters player)
        {
            try
            {
                if (item.canBeSold() == true && Inventory.isInInventory(item, player) == true)
                {
                    Inventory.removeItem(item, player);
                    cash += item.getPrice();
                }
                else
                {
                    throw new ItemNotSellable();
                }
            }
            catch
            {
                MessageBox.Show("Item couldn't be sold. Please make sure item is a weapon or a med.");
            }
        }
    }
}
