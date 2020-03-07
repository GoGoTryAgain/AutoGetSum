using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 奇奇凑数
{
    class FigureData
    {
        
        public List<List<double>> GetGatherResult(List<double> srcData, Double dataWant, Double RangeData)
        {
            List<List<double>> resultList = new List<List<double>>();
            for (int i = srcData.Count - 1; i > 0; i--)
            {
                if (srcData[i] >= dataWant || srcData[i] == 0)
                {
                    srcData.Remove(srcData[i]);
                }
            }
            srcData.Sort();
            for (int i = srcData.Count - 1; i > 0; i--)
            {
                if (srcData[0] + srcData[srcData.Count - 1] > dataWant)
                {
                    srcData.Remove(srcData[srcData.Count - 1]);
                }
            }

            int comNum = 1;
            while (comNum < srcData.Count)
            {
                Console.WriteLine("comNum = " + comNum.ToString());
                List<int> SrcDataindex = new List<int>();
                SrcDataindex.Add(0);
                for (int i = 1; i < comNum; i++)
                {
                    SrcDataindex.Add(SrcDataindex[i - 1] + 1);  //初始化索引
                }
                do
                {
                    List<double> validDataList = new List<double>();
                    bool NeedDiscardOtherTemp = false;
                    if (checkSum(ref validDataList, ref SrcDataindex, ref srcData, dataWant, RangeData, NeedDiscardOtherTemp))
                    {
                        resultList.Add(validDataList);
                        Console.WriteLine("get a  result");
                    }
                    if (NeedDiscardOtherTemp)
                    {
                        break;
                    }
                } while (ToaddIndex(ref SrcDataindex, ref srcData) && resultList.Count <= 10);
                
                comNum++;
            }

            return resultList;
        }
            

        public bool ToaddIndex(ref List<int> SrcDataindex, ref List<double> srcData)
        {
            int c = 0;
            int lastestIndex = SrcDataindex.Count - 1;
            SrcDataindex[lastestIndex]++;
            for (int i = lastestIndex; i >= 0; i--)
            {
                if (c > 0)
                {
                    SrcDataindex[i] += c;
                    for (int j = i; j + 1 <= lastestIndex; j ++)
                    {
                        SrcDataindex[j+1] = SrcDataindex[j] + 1;
                    }
                }
                
                // 判断是否最前面的数大于允许偏移的位置
                if(SrcDataindex[0] > srcData.Count - (lastestIndex) + 1)
                {
                    SrcDataindex[0] -= c;
                    Console.WriteLine("is 1 false");
                    return false;
                }
                if (SrcDataindex[i] > srcData.Count - (SrcDataindex.Count - i)) //该位偏移到了允许最大位
                {
                    c = 1;  //产生进位
                }
                else
                {
                    return true;
                }

            }
            return false;
        }

        private bool checkSum(ref List<double> validDataList, ref List<int> SrcDataindex,
            ref List<double> srcData, Double dataWant, Double RangeData,bool discradNextTemp)
        {
            double sum = 0;
            for(int i =0;i < SrcDataindex.Count; i++)
            {
               // Console.Write(srcData[SrcDataindex[i]].ToString() + " ");
                validDataList.Add(srcData[SrcDataindex[i]]);
                sum += srcData[SrcDataindex[i]];
            }
            if (System.Math.Abs(sum - dataWant) <= RangeData)
            {
                return true;
            }

            if (sum - dataWant > RangeData)
            {
                discradNextTemp = true;
            }

            return false;
        }

    }
}
