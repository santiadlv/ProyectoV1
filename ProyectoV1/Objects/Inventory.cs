using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoV1.People;
using System.Windows.Forms;
using ProyectoV1.Exceptions;

namespace ProyectoV1.Objects
{
    public static class Inventory
    {
        public static void addItem(Items x, Characters player)
        {
            try
            {
                if (x is Meds)
                    player.ownedMeds.Add((Meds)x);
                else if (x is Weapon)
                    player.ownedWeapons.Add((Weapon)x);
                else if (x is Transportation)
                    player.ownedTransports.Add((Transportation)x);
                else { throw new ItemTypeNotSupported(); }
            }
            catch (ItemTypeNotSupported) { MessageBox.Show("Item couldn't be added to Inventory. Make sure item is a weapon, transport or a med."); }
        }

        public static void removeItem(Items y, Characters player)
        {
            try
            {
                if (y is Meds)
                    player.ownedMeds.Remove((Meds)y);
                else if (y is Weapon)
                    player.ownedWeapons.Remove((Weapon)y);
                else if (y is Transportation)
                    player.ownedTransports.Add((Transportation)y);
                else { throw new ItemTypeNotSupported(); }
            }
            catch (ItemTypeNotSupported) { MessageBox.Show("Item couldn't be removed from Inventory. Make sure item is a weapon, transport or a med."); }
        }

        public static bool isInInventory(Items x, Characters player)
        {
            if (x is Meds)
            {
                foreach (Meds y in player.ownedMeds)
                {
                    if (y == x)
                    {
                        return true;
                    }
                }
                return false;
            }
            else if (x is Weapon)
            {
                foreach (Weapon y in player.ownedWeapons)
                {
                    if (y == x)
                    {
                        return true;
                    }
                }
                return false;
            }
            else if (x is Transportation)
            {
                foreach (Transportation y in player.ownedTransports)
                {
                    if (y == x)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }
    }
}
