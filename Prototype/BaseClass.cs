namespace Prototype
{
    abstract class BaseClass
    {
        protected int id;
        public BaseClass(int id)
        {
            this.id = id;
        }
        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {id}");
        }
        public abstract BaseClass Clone();
    }
}