using System;

namespace VectorTask
{
    class VectorMain
    {
        static void Main(string[] args)
        {
            var vector1 = new Vector(1, new double[] { 1, 2, 4 });
            Console.WriteLine("Вектор1: " + vector1.ToString());

            var vector2 = new Vector(2, new double[] { 1, 2, 4 });
            Console.WriteLine("Вектор2: " + vector2.ToString());

            var vector3 = new Vector(3, new double[] { 1, 2, 4 });
            Console.WriteLine("Вектор3: " + vector3.ToString());

            var vector4 = new Vector(2, new double[] { 1, 1 });
            Console.WriteLine("Вектор4: " + vector4.ToString());

            var vector5 = new Vector(2, new double[] { 2, 2 });
            Console.WriteLine("Вектор5: " + vector5.ToString());
            Console.WriteLine();

            var vector6 = new Vector(2, new double[] { -2, -2 });
            Console.WriteLine("Вектор6: " + vector6.ToString());
            Console.WriteLine();

            vector1.AddVector(vector2);
            Console.WriteLine("Сложение вектора 1 и 2 нестатическим методом: " + vector1.ToString());

            Console.WriteLine("Сложение вектора 2 и 3 статическим методом: " + Vector.GetVectorsSum(vector2, vector3).ToString());

            vector4.SubtractVector(vector5);
            Console.WriteLine("Разность векторов 5 и 4 нестатическим методом: " + vector4.ToString());

            Console.WriteLine("Разность векторов 5 и 4 статическим методом: " + Vector.GetVectorsDifference(vector5, vector4).ToString());
            Console.WriteLine();

            Console.WriteLine("Вектор1 до скалярного умножения: " + vector1.ToString());
            vector1.MultiplyScalar(2);
            Console.WriteLine("Скалярное умножение вектора1 нестатическим методом на 2: " + vector1.ToString());
            Console.WriteLine();

            Console.WriteLine("Умножение вектора1 на вектор2: " + Vector.GetScalarMultiplication(vector1, vector2));
            Console.WriteLine();

            Console.WriteLine("Вектор5 до разворота: " + vector5.ToString());
            vector5.Invert();
            Console.WriteLine("Вектор5 после разворота: " + vector5.ToString());
            Console.WriteLine();

            Console.WriteLine("Длинна вектора4: " + vector4.GetLenght());
            Console.WriteLine();

            Console.WriteLine("Вторая компанента в векторе 3 равна: " + vector3.GetComponent(1));
            Console.WriteLine("Меняем эту компаненту на 6: ");
            vector3.SetComponent(6, 1);
            Console.WriteLine("Теперь компанента равна: " + vector3.GetComponent(1));
            Console.WriteLine();

            Console.WriteLine($"Вектор5 {vector5} {(vector5.Equals(vector6) ? "равен" : "не равен" )} вектору6 {vector6}");
            Console.WriteLine($"Вектор5 {vector5} {(vector5.Equals(vector3) ? "равен" : "не равен")} вектору3 {vector3}");
        }   
    }
}
