using H2_Assignment_Coffee_Machine.Models;
using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using H2_Assignment_Coffee_Machine.Models.CoffeeMachines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CapsuleCoffeeMachine capsuleCoffeeMachine = new CapsuleCoffeeMachine("JustABrand", 10, 30, new WaterContainer(6));
            Capsule iceCoffeeCapsule = new Capsule("Ice Coffee");

            capsuleCoffeeMachine.TogglePower();
            capsuleCoffeeMachine.WaterContainer.AddFluid(0.5f);
            capsuleCoffeeMachine.InsertCapsule(iceCoffeeCapsule);
            Console.WriteLine(capsuleCoffeeMachine.Brew());

            DripCoffeeMachine dripCoffeeMachine = new DripCoffeeMachine("EvenCoolerBrand", 20, 50, new WaterContainer(5), new FilterContainer(), 300);
            Bean meanieBean = new Bean("Meanie Bean", 0.2f);
            Filter paperFilterDrip = new Filter();

            List<Bean> meanieBeans = new List<Bean>();
            for(int i = 0; i < 100; i++)
            {
                meanieBeans.Add(meanieBean);
            }

            
            dripCoffeeMachine.TogglePower();
            dripCoffeeMachine.WaterContainer.AddFluid(3);
            dripCoffeeMachine.FilterContainer.InsertFilter(paperFilterDrip);
            dripCoffeeMachine.InsertBeans(meanieBeans);
            Console.WriteLine(dripCoffeeMachine.Brew());

            EspressoCoffeeMachine espressoCoffeeMachine = new EspressoCoffeeMachine("EvenCoolerBrand", 20, 80, new WaterContainer(7), new FilterContainer(), 400);
            Bean happyBean = new Bean("Happy Bean", 0.2f);
            Filter paperFilterEspresso = new Filter();
            
            List<Bean> happyBeans = new List<Bean>();
            for(int i = 0; i < 110; i++)
            {
                happyBeans.Add(happyBean);
            }

            espressoCoffeeMachine.TogglePower();
            espressoCoffeeMachine.WaterContainer.AddFluid(3f);
            espressoCoffeeMachine.FilterContainer.InsertFilter(paperFilterDrip);
            espressoCoffeeMachine.InsertBeans(happyBeans);
            Console.WriteLine(espressoCoffeeMachine.Brew());

            TeaMachine teaMachine = new TeaMachine("TeaMachiny", 20, 30, new WaterContainer(4), new Infuser());
            TeaBag teaBag = new TeaBag("Green Tea");

            teaMachine.TogglePower();
            teaMachine.WaterContainer.AddFluid(2f);
            teaMachine.Infuser.InsertTeaBag(teaBag);
            Console.WriteLine(teaMachine.Brew());

            Console.ReadLine();
        }
    }
}
