using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;



namespace FarmbrellaSite
{
    public static class CouponGenerator
    {

        private static int coupon;
        private static Random ring = new Random();

       
        public static int GetCoupon()
        {

            List<int> numbers = new List<int>();
            for(int a = 1;a<9005;a++)
            {
                numbers.Add(a);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
               int temp = numbers[i];
                int randomIndex = ring.Next(i, numbers.Count);
                numbers[i] = numbers[randomIndex];
                numbers[randomIndex] = temp;
            }
            List<int> nums = numbers;

            List<int> finalList = new List<int>();
            for(int a=0;a<nums.Count;a++)
            {
                while(nums.IndexOf(a) > 1003)
                {
                    finalList.Add(nums.IndexOf(a));
                    break;
                }
              
            }

            foreach(int i in finalList)
            {
                coupon = i;
            }

            return coupon;

        }
    }

    
}