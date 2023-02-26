namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Point objects
            var p1 = new Class_Point(0, 0);
            var p2 = new Class_Point(10, 20);

            // Pair ojbects (Type parameters)
            var pair = new TypeParameters_Pair<int, string>(1, "two");
            int i = pair.First;     //TFirst int
            string s = pair.Second; //TSecond string

            // Base class example
            Class_Point a = new(10, 20);
            Class_Point b = new InheritClass_Point3D(10, 20, 30);

            // Interfaces
            Interfaces_EditBox editBox = new();
            IControl control = editBox;
            IDataBound dataBound = editBox;
        }
    }
}