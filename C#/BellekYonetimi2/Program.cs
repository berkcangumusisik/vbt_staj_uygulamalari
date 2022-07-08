using System.Runtime.Serialization.Formatters.Binary;

namespace Vbt
{
    public class VBT
    {
        [Serializable]
        public class Address : IDisposable
        {
            private bool _disposed;
            public string Street { get; set; }
            public string City { get; set; }
            public string Country { get; set; }

            ~Address() => Dispose(false);
            protected virtual void Dispose(bool disposing)
            {
                if (_disposed)
                {
                    return;
                }
                if (disposing)
                {
                    //TODO
                }
                _disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
        [Serializable]
        public class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Address Address { get; set; }
            public Customer ShallowCopy()
            {
                return this.MemberwiseClone() as Customer;
            }

            public Customer DeepCopy()
            {
                using (var ms = new MemoryStream())
                {
                    var formatter = new BinaryFormatter(); formatter.Serialize(ms, this);
                    ms.Position = 0;
                    return (Customer)formatter.Deserialize(ms);

                }
            }
        }


        static void Main(string[] args)
        {
            using (var ad = new Address())
            {

            }
            Customer ali = new Customer()
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Varol",
                Address = new Address()
                {
                    City = "Ankara",
                    Street = "Sincan",
                    Country = "Türkiye"
                }
            };

            //Customer veli = ali.ShallowCopy();
            Customer veli = ali.DeepCopy();
            veli.FirstName = "Veli";
            veli.Address.Street = "Yenimahalle";
            Console.WriteLine(veli.Address.Street);
            Console.WriteLine(veli.FirstName);
            Console.WriteLine(veli.LastName);
        }
    }
}

/*
 ShallowCopy() => preemptive  typeları kopyalar. complex olanları kopyalayamaz.
 DeepCopy() => complex type olanları da kopyalar.
 Scopped ile önce oluşturur sonra işi bitince kaldırır.
 */