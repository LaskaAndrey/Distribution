// Laska Andrey

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace distribution
{
    internal class Methods
    {
        public static Random rand = new Random();
        //Метод Неймона
        public static double Neymon(double constA, double qMax, double left, double right)
        {
            double xN, yN;
            do
            {
                xN = left + (right - left)*rand.NextDouble();       //генерация координаты Х
                yN = qMax*rand.NextDouble();                        //генерация координаты У
            } while (Function(constA, xN) < yN);                    //генерируем до тех пор, пока точка не попала под график
            return xN;                                              //точка попала, запоминаем координату Х
        }

        //Метод Метрополиса
        public static double Metropolis(double constA, double left, double right, double xM, double delta)
        {
            double xNext, pI;

            xNext = xM + delta*(2*rand.NextDouble() - 1);           //генерим следующую точку от xM
            pI = Function(constA, xNext)/Function(constA, xM);      //отношение функции следующей точки к функции исходной

            if (pI > 1)               //если отношение больше 1
                xM = xNext;            //точка нам подходит, запоминаем ее, что бы потом считать от новой

            if (rand.NextDouble() < pI)     //если отношение больше ГСВ
                xM = xNext;               //точка нам подходит, запоминаем ее, что бы потом считать от новой

            return xM;                   //иначе, возвращаемся к исходной точке
        }

        //высчитывание дисперсии
        public static double Disp(List<double> myList, double summ)
        {
            double ds = 0, sqSum = 0;
            sqSum = myList.Sum(i => i*i);
            ds = Math.Sqrt(1.0/(myList.Count - 1)*(sqSum - myList.Count*Math.Pow(summ, 2)));

            return ds;
        }

        public static double Mean(List<double> myList)
        {
            return (myList.Sum()/myList.Count);
        }

        //метод обратных ф.
        public static double Inverse(double constA)
        {
            return constA*InverseCDF(rand.NextDouble());
        }

        //Maxwell-Bolzman distribution PDF
        public static double Function(double a, double x)
        {
            return (Math.Sqrt(2/Math.PI)*(Math.Pow(x, 2)*Math.Exp(-Math.Pow(x, 2)/(2*Math.Pow(a, 2))))/Math.Pow(a, 3));
        }

        //обратная функция
        private static double InverseCDF(double constA)
        {
            double x;
            if (constA < 0.346691)
            {
                x = 1.0642622768277956e-6*Math.Sqrt(2.1347980205189531e12*Math.Pow(constA, 0.6666666666666666) +
                                                    1.0323831697580514e12*Math.Pow(constA, 1.3333333333333333) +
                                                    6.775644406955992e11*constA*constA +
                                                    5.0331929839908344e11*Math.Pow(constA, 2.6666666666666665) +
                                                    3.9996925883820276e11*Math.Pow(constA, 3.3333333333333335) +
                                                    3.3163359755658606e11*Math.Pow(constA, 4) +
                                                    2.831279191020564e11*Math.Pow(constA, 4.666666666666667));
            }
            else if (constA < 0.796567)
            {
                x = 0.014527571050476862 + constA*(9.294742731011485 + 
                    constA*(-37.43519439668487 + constA*(105.40885039276776 +
                    constA*(-183.6190579712269 + constA*(196.7067172374017 +
                    constA*(-118.99569035897035 + 31.66450688674963*constA))))));
            }
            else
            {
                x = (-665.6950297578719 + constA*(13652.127578664917 +
                    constA*(-47641.68123439248 + constA*(73592.91391855325 +
                    constA*(-60775.51067786972 + (27088.54652502034 - 5250.64365989075*constA)*constA)))))/
                    (2004.625993588326 + constA*(-5790.900684890041 + 
                    (5572.531218092137 - 1786.242621106215*constA)*constA));
            }
            return x;
        }
    }
}