using System;

namespace VectorTask
{
    class Vector
    {
        private double[] components;

        public Vector(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размерность вектора должна быть больше 0!");
            }

            components = new double[n];
        }

        public Vector(Vector vector)
        {
            components = new double[vector.components.Length];
            Array.Copy(vector.components, components, vector.components.Length);
        }

        public Vector(double[] array)
        {
            if (components.Length == 0)
            {
                throw new ArgumentException("Размерность вектора должна быть больше 0!");
            }

            components = new double[array.Length];
            Array.Copy(array, components, array.Length);
        }

        public Vector(int n, double[] array)
        {
            components = new double[n];
            Array.Copy(array, components, Math.Min(n, array.Length));
        }

        public int GetSize(double[] components)
        {
            return components.Length;
        }

        public override string ToString()
        {
            return $"{{{string.Join(", ", components)}}}";
        }

        public void AddVector(Vector vector)
        {
            if (components.Length < vector.components.Length)
            {
                Array.Resize(ref components, vector.components.Length);
            }

            for (int i = 0; i < vector.components.Length; i++)
            {
                components[i] += vector.components[i];
            }
        }

        public void SubtractVector(Vector vector)
        {
            if (components.Length < vector.components.Length)
            {
                Array.Resize(ref components, components.Length);
            }

            for (int i = 0; i < vector.components.Length; i++)
            {
                components[i] -= vector.components[i];
            }
        }

        public void MultiplyScalar(double scalar)
        {
            for (int i = 0; i < components.Length; i++)
            {
                components[i] *= scalar;
            }
        }

        public void Invert()
        {
            MultiplyScalar(-1);
        }

        public double GetLenght()
        {
            double squaresSum = 0;

            foreach (double component in components)
            {
                squaresSum += Math.Pow(component, 2);
            }

            return Math.Sqrt(squaresSum);
        }

        public double GetComponent(int index)
        {
            return components[index];
        }

        public void SetComponent(double component, int index)
        {
            components[index] = component;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (ReferenceEquals(obj, null) || obj.GetType() != GetType())
            {
                return false;
            }

            Vector vector = (Vector)obj;

            if (vector.components.Length != components.Length)
            {
                return false;
            }

            for (int i = 0; i < components.Length; i++)
            {
                if (components[i] != vector.components[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int prime = 17;
            int hash = 0;

            for (int i = 0; i < components.Length; i++)
            {
                hash = prime * hash + (int)components[i];
            }

            return hash;
        }

        public static Vector GetVectorsSum(Vector vector1, Vector vector2)
        {
            Vector vectorCopy = new Vector(vector1);
            vectorCopy.AddVector(vector2);

            return vectorCopy;
        }

        public static Vector GetVectorsDifference(Vector vector1, Vector vector2)
        {
            Vector vectorCopy = new Vector(vector1);
            vectorCopy.SubtractVector(vector2);

            return vectorCopy;
        }

        public static double GetScalarMultiplication(Vector vector1, Vector vector2)
        {
            int minLenght = Math.Min(vector1.components.Length, vector2.components.Length);
            double scalar = 0;

            for (int i = 0; i < minLenght; i++)
            {
                scalar += vector1.components[i] * vector2.components[i];
            }

            return scalar;
        }
    }
}
