using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
    public class Player
    {
        private IWeapon weapon;

        public Player(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void SetWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
            Console.WriteLine($"Switched to {weapon.GetType().Name}");
        }

        public void Attack()
        {
            weapon.UseWeapon();
        }
    }
}
