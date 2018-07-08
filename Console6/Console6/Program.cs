using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6
{
    class Program //: CommandLineParser 봉인클래스(sealed 한정자) 상속 불가능
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact("");
            //contact.Name = "Iniho Montoya";

            PdaItem item = contact;
            //파생형식이 암시적으로 기본 형식으로 변환 될 수 있음
            //contact = (Contact)item;
            //기본 형식은 명시적으로 파생 형식으로 캐스팅 되어야 함

            //contact._Name = "";
            //보호 수준으로 인해 액세스 불가 (_Name -> Private 접근 한정자)

            item.Name = "Inigo Montoya";
            Console.WriteLine(contact.FirstName+contact.LastName);
            //최하위에서 파생된 구현을 호출


        }

        //다중 상속 클래스 구조
        //private Person InternalPerson { get; set; }
        
        //public string FirstName
        //{
        //    get { return InternalPerson.FirstName; }
        //    set { InternalPerson.FirstName = value; }
        //}
        //public string LastName
        //{
        //    get { return InternalPerson.LastName; }
        //    set { InternalPerson.LastName = value; }
        //}
        
        public class BaseClass
        {
            public void DisplayName()
            {
                Console.WriteLine("BaseClass");
            }
        }
        public class DeriveClass : BaseClass
        {
            //BaseClass에서 상속된 DisplayName을 숨김
            //의도적으로 숨기기 위해서 new 키워드 사용
            public virtual void DisplayName()
            {

            }
            
        }

        public class Address
        {
            public string City;
            public string Zip;
            public override string ToString()
            {
                return City + Zip;
            }
        }
        public class InternationalAddress :Address
        {
            public string Country;
            public override string ToString()
            {
                return base.ToString() + Country;
                //기본(부모) 클래스의 멤버를 호출하고 싶을 때 사용
            }
        }

        public abstract class AbstractClass
        {
            public virtual string Name { get; set; }
            public AbstractClass(string name)
            {
                Name = name;
            }

            public abstract string GetSummary();
            //추상 멤버 정의
        }
        public class AbstractTestClass : AbstractClass
        {
            public AbstractTestClass(string name) : base(name)
            {
                Name = name;
            }
            //AbstractClass AbC;
            //AbC = new AbstractClass("");
            //추상 클래스의 인스턴스 생성 불가
            public override string Name { get => base.Name; set => base.Name = value; }
            public override string GetSummary()
            {
                throw new NotImplementedException();
                //추상 클래스의 메소드 재정의
            }
        }

    }
}
