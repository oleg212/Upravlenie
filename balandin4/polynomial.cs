using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balandin4
{
    internal class Monomial
    {
        private double coefficient;
        private int[] powers;

        public Monomial(double coefficient, int[] powers)
        {
            if (powers.Length != 10)
            {
                throw new ArgumentException("The powers array must have a length of 10.");
            }

            this.coefficient = coefficient;
            this.powers = powers.ToArray(); // Создаем копию массива степеней
        }

        public Monomial(double coefficient)
        {
            

            this.coefficient = coefficient;
            this.powers= new int[10]; 
            for (int i=0;i<10;i++)
            {
                this.powers[i] = 0;
            }
        }

        public double Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }

        public int[] Powers
        {
            get { return powers; }
        }

        // Умножение монома на другой моном
        public static Monomial Multiply(Monomial m1, Monomial m2)
        {
            double resultCoefficient = m1.coefficient * m2.coefficient;
            int[] resultPowers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                resultPowers[i] = m1.powers[i] + m2.powers[i];
            }

            return new Monomial(resultCoefficient, resultPowers);
        }

        // Перегрузка оператора умножения для удобства использования
        public static Monomial operator *(Monomial m1, Monomial m2)
        {
            return Multiply(m1, m2);
        }

        // Перегрузка оператора сложения для мономов с одинаковыми степенями
        public static Monomial operator +(Monomial m1, Monomial m2)
        {
            if (!Enumerable.SequenceEqual(m1.powers, m2.powers))
            {
                throw new ArgumentException("Monomials must have the same powers for addition.");
            }

            double resultCoefficient = m1.coefficient + m2.coefficient;
            int[] resultPowers = m1.powers.ToArray(); // Создаем копию массива степеней

            return new Monomial(resultCoefficient, resultPowers);
        }
    }

    internal class Polynomial
    {
        private System.Collections.Generic.List<Monomial> monomials = new System.Collections.Generic.List<Monomial>();

        // Добавление монома в полином
        public void AddMonomial(Monomial monomial)
        {
            monomials.Add(monomial);
        }

        //Значение в точке
        public double Evaluate(List<double> xValues)
        {
            //if (xValues.Count != 10)
            //{
            //    throw new ArgumentException("The array of x values must have a length of 10.");
            //}

            double result = 0;

            foreach (Monomial monomial in monomials)
            {
                double termValue = monomial.Coefficient;

                for (int i = 0; i < Math.Min(xValues.Count, 10); i++)
                {
                    termValue *= Math.Pow(xValues[i], monomial.Powers[i]);
                }

                result += termValue;
            }

            return result;
        }

        // Функция, возвращающая лямбда-функцию для вычисления значения полинома в точке
        public Func<List<double>, double> GetEvaluator()
        {
            return (List<double> x) =>
            {
                double result = 0;

                foreach (Monomial monomial in monomials)
                {
                    double termValue = monomial.Coefficient;

                    for (int i = 0; i < Math.Min(10,x.Count); i++)
                    {
                        termValue *= Math.Pow(x[i], monomial.Powers[i]);
                    }

                    result += termValue;
                }

                return result;
            };
        }

        // Удаление монома из полинома
        public void RemoveMonomial(Monomial monomial)
        {
            monomials.Remove(monomial);
        }

        // Умножение полинома на другой полином
        public static Polynomial Multiply(Polynomial p1, Polynomial p2)
        {
            Polynomial result = new Polynomial();

            foreach (Monomial m1 in p1.monomials)
            {
                foreach (Monomial m2 in p2.monomials)
                {
                    result.AddMonomial(Monomial.Multiply(m1, m2));
                }
            }

            // Объединяем мономы с одинаковыми степенями в один моном
            result.CombineLikeTerms();

            return result;
        }

        // Сложение полинома с другим полиномом
        public static Polynomial Add(Polynomial p1, Polynomial p2)
        {
            Polynomial result = new Polynomial();

            result.monomials.AddRange(p1.monomials);
            result.monomials.AddRange(p2.monomials);

            // Объединяем мономы с одинаковыми степенями в один моном
            result.CombineLikeTerms();

            return result;
        }

        public static Polynomial Subtract(Polynomial p1, Polynomial p2)
        {
            Polynomial result = new Polynomial();

            result.monomials.AddRange(p1.monomials);

            foreach (Monomial m2 in p2.monomials)
            {
                // Создаем моном с отрицательным коэффициентом
                Monomial subtractedMonomial = new Monomial(-m2.Coefficient, m2.Powers);
                result.AddMonomial(subtractedMonomial);
            }

            // Объединяем мономы с одинаковыми степенями в один моном
            result.CombineLikeTerms();

            return result;
        }

        // Объединение мономов с одинаковыми степенями в один моном
        private void CombineLikeTerms()
        {
            for (int i = 0; i < monomials.Count; i++)
            {
                for (int j = i + 1; j < monomials.Count; j++)
                {
                    if (Enumerable.SequenceEqual(monomials[i].Powers, monomials[j].Powers))
                    {
                        monomials[i] += monomials[j];
                        monomials.RemoveAt(j);
                        j--;
                    }
                }
            }
        }

        // Перегрузка оператора умножения для удобства использования
        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            return Multiply(p1, p2);
        }

        // Перегрузка оператора сложения для удобства использования
        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            return Add(p1, p2);
        }

        // Перегрузка оператора вычитания для удобства использования
        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            return Subtract(p1, p2);
        }

        // Вывод полинома на консоль
        public void Print()
        {
            foreach (Monomial monomial in monomials)
            {
                Console.Write($"{monomial.Coefficient} * ");
                for (int i = 0; i < 10; i++)
                {
                    if (monomial.Powers[i] > 0)
                    {
                        Console.Write($"x{i}^{monomial.Powers[i]} ");
                    }
                }
                Console.Write("+ ");
            }
            Console.WriteLine();
        }
    }
}
