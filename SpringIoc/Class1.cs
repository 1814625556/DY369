using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringIoc
{
    public class Happy
    {
        public override string ToString()
        {
            return "每天都开心，每天都有好心情";
        }
    }

    public class OneYear
    {
        public override string ToString()
        {
            return "快乐的一年";
        }
    }

    public class Person
    {
        public IEnumerable<Person> BestFriends { get; set; }

        public IList HappyYears { get; set; }

        public IEnumerable<int> Years { get; set; }

        public IDictionary HappyDic { get; set; }

        public IDictionary<string, object> HappyTimes { get; set; }

        public string Name { get; set; }
    }

    public class Perple
    {
        public string Name { get; set; }
    }
}
