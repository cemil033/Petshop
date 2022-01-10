

using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Cathouse
    {
        public List<Cat> cats;
        public Cathouse()
        {
            cats =new();
        }
        public Cathouse(List<Cat> cts)
        {
            cats = cts;
           
        }
        public void AddCat(Cat cat) {
            
            cats.Add(cat);
        }
        public void RemoveByNickname(string nick)
        {
            foreach (var item in cats)
            {
                if (item.nickname==nick)
                {
                    cats.Remove(item);
                }
            }
        }
    }
}
