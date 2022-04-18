using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exiled.API.Features;
using System.Timers;
using MEC;

namespace GuardToMtf
{
    public class Start
    {
        private static Timer aTimer;

        public void OnRoundStarted()
        {
            NastavitZacatekTimer();
        }

        public static void NastavitZacatekTimer()
        {
            aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += ZacatekTImer;
            aTimer.Enabled = true;
        }



        private static void ZacatekTImer(Object source, ElapsedEventArgs e)
        {

            UnityEngine.Vector3 Escape = new UnityEngine.Vector3(170.4f, 984.6f, 31.9f);


            foreach (Player player in Player.List)
            {
                if (!player.IsCuffed)
                {
                    if (player.Role == RoleType.FacilityGuard)
                    {
                        if (UnityEngine.Vector3.Distance(player.Position, Escape) < 10f)
                        {
                            var InventoryList = new List<ItemType>();


                             foreach (var item in player.Items)
                            {
                                InventoryList.Add(item.Type);
                            }
                            player.DropItems();

                            player.SetRole(RoleType.NtfSergeant);

                           
                        }
                    }
                }
            }
        }
        }
}
