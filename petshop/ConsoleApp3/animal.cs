

namespace ConsoleApp3
{
    abstract public class animal
    {
        public int age;
        public bool gender;
        public animal()
        {
            age = 0;
            gender = false;
        }
        public animal(int age, bool gender)
        {
            this.age = age;
            this.gender = gender;
        }

    }
}
