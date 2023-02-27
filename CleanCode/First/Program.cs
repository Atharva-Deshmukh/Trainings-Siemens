
/*
    calculates factorial of a the number. Takes positive number as i/p and returns factorial of the number. If invalid i/p, it returns -1
*/

int Factorial(int number)
{
    if(number >= 0)
    {
        int ans = 1;
        /*
            yaha function ka logic likha karo whenever kisi function ka logic sirf aapne pta kiya hai
        */

        for (int i = 2; i <= number; i++)
        {
            ans = ans * i;
        } 

        return ans;
    }

    else
    {
        return -1;
    }
     
    
}