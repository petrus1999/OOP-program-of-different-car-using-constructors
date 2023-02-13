using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_program_of_different_car_using_constructors
{
     class Car
    {
        string brand;
        int price;

        // parameterized constructor
        Car(string theBrand, int thePrice)
        {

            brand = theBrand;
            price = thePrice;
        }
}
