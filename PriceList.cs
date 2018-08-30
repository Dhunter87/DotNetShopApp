using System;
using System.Collections.Generic;
namespace SelfTrainingProject.DotNetShop
{
    public class PriceList
    {
        Basket basket = new Basket();

        public List<double> prices = new List<double>
        {19.99, 24.99, 29.99, 34.99, 39.99, 44.99, 49.99, 54.99, 59.99, 64.99, 69.99};

        public double GetPrice(string code)
        {
            if (string.Equals(code, "MK1N") || (string.Equals(code, "MK2N")||
               (string.Equals(code, "MK3N") || (string.Equals(code, "MK4N")|| (string.Equals(code, "MK5N"))))))
            {
                return basket.price[basket.arrayIndex] = prices[9];
            }
            else if (string.Equals(code, "MK1A") || (string.Equals(code, "MK2A") ||
                    (string.Equals(code, "MK3A") || (string.Equals(code, "MK4A") || (string.Equals(code, "MK5A")||
                    (string.Equals(code, "WK1N") || (string.Equals(code, "WK2N") ||
                    (string.Equals(code, "WK3N") || (string.Equals(code, "WK4N") || (string.Equals(code, "WK5N")))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[8];
            }
            else if (string.Equals(code, "MK1P") || (string.Equals(code, "MK2P") ||
                    (string.Equals(code, "MK3P") || (string.Equals(code, "MK4P") || (string.Equals(code, "MK5P") ||
                    (string.Equals(code, "WK1A") || (string.Equals(code, "WK2A") ||
                    (string.Equals(code, "WK3A") || (string.Equals(code, "WK4A") || (string.Equals(code, "WK5A")))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[7];
            }
            else if //(string.Equals(code, "MT1L") || (string.Equals(code, "WT1C")))
                    (string.Equals(code, "MK1C") || (string.Equals(code, "MK2C") ||
                    (string.Equals(code, "MK3C") || (string.Equals(code, "MK4C") || (string.Equals(code, "MK5C") ||
                    (string.Equals(code, "WK1P") || (string.Equals(code, "WK2P") ||
                    (string.Equals(code, "WK3P") || (string.Equals(code, "WK4P") || (string.Equals(code, "WK5P")))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[6];
            }
            else if //(string.Equals(code, "WT1L"))
                    (string.Equals(code, "MK1L") || (string.Equals(code, "MK2L") ||
                    (string.Equals(code, "MK3L") || (string.Equals(code, "MK4L") || (string.Equals(code, "MK5L") ||
                    (string.Equals(code, "WK1C") || (string.Equals(code, "WK2C") ||
                    (string.Equals(code, "WK3C") || (string.Equals(code, "WK4C") || (string.Equals(code, "WK5C")))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[5];
            }
            else if (string.Equals(code, "WK1L") || (string.Equals(code, "WK2L") || (string.Equals(code, "WK3L") || (string.Equals(code, "WK4L") || (string.Equals(code, "WK5L")||
                    (string.Equals(code, "MH1N") || (string.Equals(code, "MH2N") || (string.Equals(code, "MH3N") || (string.Equals(code, "MH4N") || (string.Equals(code, "MH5N") ||
                    (string.Equals(code, "MH1A") || (string.Equals(code, "MH2A") || (string.Equals(code, "MH3A") || (string.Equals(code, "MH4A") || (string.Equals(code, "MH5A"))))))))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[4];
            }
            else if (string.Equals(code, "MH1P") || (string.Equals(code, "MH2P") || (string.Equals(code, "MH3P") || (string.Equals(code, "MH4P") || (string.Equals(code, "MH5P") ||
                    (string.Equals(code, "MH1C") || (string.Equals(code, "MH2C") || (string.Equals(code, "MH3C") || (string.Equals(code, "MH4C") || (string.Equals(code, "MH5C") ||
                    (string.Equals(code, "MH1L") || (string.Equals(code, "MH2L") || (string.Equals(code, "MH3L") || (string.Equals(code, "MH4L") || (string.Equals(code, "MH5L") ||
                    (string.Equals(code, "MB1N") || (string.Equals(code, "MB2N") || (string.Equals(code, "MB3N") || (string.Equals(code, "MB4N") || (string.Equals(code, "MB5N") ||
                    (string.Equals(code, "MB1A") || (string.Equals(code, "MB2A") || (string.Equals(code, "MB3A") || (string.Equals(code, "MB4A") || (string.Equals(code, "MB5A") ||
                    (string.Equals(code, "WH1N") || (string.Equals(code, "WH2N") || (string.Equals(code, "WH3N") || (string.Equals(code, "WH4N") || (string.Equals(code, "WH5N") ||
                    (string.Equals(code, "WH1A") || (string.Equals(code, "WH2A") || (string.Equals(code, "WH3A") || (string.Equals(code, "WH4A") || (string.Equals(code, "WH5A"))))))))))))))))))))))))))))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[3];
            }
            else if (string.Equals(code, "MB1P") || (string.Equals(code, "MB2P") || (string.Equals(code, "MB3P") || (string.Equals(code, "MB4P") || (string.Equals(code, "MB5P") ||
                    (string.Equals(code, "MB1C") || (string.Equals(code, "MB2C") || (string.Equals(code, "MB3C") || (string.Equals(code, "MB4C") || (string.Equals(code, "MB5C") ||
                    (string.Equals(code, "MB1L") || (string.Equals(code, "MB2L") || (string.Equals(code, "MB3L") || (string.Equals(code, "MB4L") || (string.Equals(code, "MB5L") ||
                    (string.Equals(code, "WH1P") || (string.Equals(code, "WH2P") || (string.Equals(code, "WH3P") || (string.Equals(code, "WH4P") || (string.Equals(code, "WH5P") ||
                    (string.Equals(code, "WH1C") || (string.Equals(code, "WH2C") || (string.Equals(code, "WH3C") || (string.Equals(code, "WH4C") || (string.Equals(code, "WH5C") ||
                    (string.Equals(code, "WH1L") || (string.Equals(code, "WH2L") || (string.Equals(code, "WH3L") || (string.Equals(code, "WH4L") || (string.Equals(code, "WH5L") ||
                    (string.Equals(code, "WB1N") || (string.Equals(code, "WB2N") || (string.Equals(code, "WB3N") || (string.Equals(code, "WB4N") || (string.Equals(code, "WB5N") ||
                    (string.Equals(code, "WB1A") || (string.Equals(code, "WB2A") || (string.Equals(code, "WB3A") || (string.Equals(code, "WB4A") || (string.Equals(code, "WB5A")))))))))))))))))))))))))))))))))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[2];
            }
            else if (string.Equals(code, "MT1N") || (string.Equals(code, "MT2N") || (string.Equals(code, "MT3N") || (string.Equals(code, "MT4N") || (string.Equals(code, "MT5N") ||
                    (string.Equals(code, "MT1A") || (string.Equals(code, "MT2A") || (string.Equals(code, "MT3A") || (string.Equals(code, "MT4A") || (string.Equals(code, "MT5A") ||
                    (string.Equals(code, "WT1N") || (string.Equals(code, "WT2N") || (string.Equals(code, "WT3N") || (string.Equals(code, "WT4N") || (string.Equals(code, "WT5N") ||
                    (string.Equals(code, "MT1P") || (string.Equals(code, "MT2P") || (string.Equals(code, "MT3P") || (string.Equals(code, "MT4P") || (string.Equals(code, "MT5P") ||
                    (string.Equals(code, "WT1A") || (string.Equals(code, "WT2A") || (string.Equals(code, "WT3A") || (string.Equals(code, "WT4A") || (string.Equals(code, "WT5A") ||
                    (string.Equals(code, "MS1N") || (string.Equals(code, "MS2N") || (string.Equals(code, "MS3N") || (string.Equals(code, "MS4N") || (string.Equals(code, "MS5N") ||
                    (string.Equals(code, "MS1A") || (string.Equals(code, "MS2A") || (string.Equals(code, "MS3A") || (string.Equals(code, "MS4A") || (string.Equals(code, "MS5A") ||
                    (string.Equals(code, "WS1N") || (string.Equals(code, "WS2N") || (string.Equals(code, "WS3N") || (string.Equals(code, "WS4N") || (string.Equals(code, "WS5N") ||
                    (string.Equals(code, "MS1P") || (string.Equals(code, "MS2P") || (string.Equals(code, "MS3P") || (string.Equals(code, "MS4P") || (string.Equals(code, "MS5P") ||
                    (string.Equals(code, "WS1A") || (string.Equals(code, "WS2A") || (string.Equals(code, "WS3A") || (string.Equals(code, "WS4A") || (string.Equals(code, "WS5A") ||
                    (string.Equals(code, "WB1P") || (string.Equals(code, "WB2P") || (string.Equals(code, "WB3P") || (string.Equals(code, "WB4P") || (string.Equals(code, "WB5P") ||
                    (string.Equals(code, "WB1C") || (string.Equals(code, "WB2C") || (string.Equals(code, "WB3C") || (string.Equals(code, "WB4C") || (string.Equals(code, "WB5C") ||
                    (string.Equals(code, "WB1L") || (string.Equals(code, "WB2L") || (string.Equals(code, "WB3L") || (string.Equals(code, "WB4L") || (string.Equals(code, "WB5L") )))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[1];
            }
            else if (string.Equals(code, "MT1C") || (string.Equals(code, "MT2C") || (string.Equals(code, "MT3C") || (string.Equals(code, "MT4C") || (string.Equals(code, "MT5C") ||
                    (string.Equals(code, "WT1P") || (string.Equals(code, "WT2P") || (string.Equals(code, "WT3P") || (string.Equals(code, "WT4P") || (string.Equals(code, "WT5P") ||
                    (string.Equals(code, "MT1L") || (string.Equals(code, "MT2L") || (string.Equals(code, "MT3L") || (string.Equals(code, "MT4L") || (string.Equals(code, "MT5L") ||
                    (string.Equals(code, "WT1C") || (string.Equals(code, "WT2C") || (string.Equals(code, "WT3C") || (string.Equals(code, "WT4C") || (string.Equals(code, "WT5C") ||
                    (string.Equals(code, "WT1L") || (string.Equals(code, "WT2L") || (string.Equals(code, "WT3L") || (string.Equals(code, "WT4L") || (string.Equals(code, "WT5L") ||
                    (string.Equals(code, "MS1C") || (string.Equals(code, "MS2C") || (string.Equals(code, "MS3C") || (string.Equals(code, "MS4C") || (string.Equals(code, "MS5C") ||
                    (string.Equals(code, "WS1P") || (string.Equals(code, "WS2P") || (string.Equals(code, "WS3P") || (string.Equals(code, "WS4P") || (string.Equals(code, "WS5P") ||
                    (string.Equals(code, "MS1L") || (string.Equals(code, "MS2L") || (string.Equals(code, "MS3L") || (string.Equals(code, "MS4L") || (string.Equals(code, "MS5L") ||
                    (string.Equals(code, "WS1C") || (string.Equals(code, "WS2C") || (string.Equals(code, "WS3C") || (string.Equals(code, "WS4C") || (string.Equals(code, "WS5C") ||
                    (string.Equals(code, "WS1L") || (string.Equals(code, "WS2L") || (string.Equals(code, "WS3L") || (string.Equals(code, "WS4L") || (string.Equals(code, "WS5L")))))))))))))))))))))))))))))))))))))))))))))))))))
            {
                return basket.price[basket.arrayIndex] = prices[0];
            }
            else
            {
                return basket.price[basket.arrayIndex] = 0.0;
            }
        }
    }
}
