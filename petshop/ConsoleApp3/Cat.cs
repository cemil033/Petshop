

namespace ConsoleApp3
{
    public class Cat :animal
    {
        public string nickname;
        public int Energy;
        public double Price;
        public int mealQuantitiy;
        public Cat(): base() {
            nickname = null;
            Energy = 0;
            Price = 0;
            mealQuantitiy = 0;
        }
        public Cat(int age,bool gender,string nickname, int energy, double price, int mealQuantitiy):base(age,gender)
        {
            this.nickname = nickname;
            Energy = energy;
            Price = price;
            this.mealQuantitiy = mealQuantitiy;
        }
        public void Eat()
        {
            mealQuantitiy++;
            Price += 1.5;
            Energy++;
        }
        public void Sleep()
        {
            Energy++;
        }
        public void Play()
        {
            Energy--;
        }
    }
}
