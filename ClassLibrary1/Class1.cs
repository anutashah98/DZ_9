using ConsoleApplication1;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void Test()
        {
            Archer archer = new Archer();
            archer.ShootWithBow = "1 metr";
            archer.Damage = 60;

            Mage mage = new Mage();
            mage.Magic = 30;
            mage.Damage = 90;

            Knight knight = new Knight();
            knight.Damage = 80;

            Unit curentUnit = archer;
            curentUnit.Attack();

            curentUnit = mage;
            curentUnit.Attack();

            curentUnit = knight;
            curentUnit.Attack();
        }
    }
}