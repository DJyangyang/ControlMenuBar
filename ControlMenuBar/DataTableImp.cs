
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMenuBar
{
    class DataTableImp
    {
        internal static System.Data.DataTable GetTableByFieldNamesAndRowNumRange(System.Data.DataTable sourceDt, List<string> fieldNames, List<string> fieldNames1, int startRowNum, int endRowNum)
        {
            DataTable tempDt = GetTableByFieldNames(sourceDt, fieldNames, fieldNames1); //筛选指定列
            DataTable resultDt = GetTableByRowNumRange(tempDt, startRowNum, endRowNum);//筛选指定行

            return resultDt;
        }

        public static DataTable GetTableByRowNumRange(DataTable sourceDt, int startRowNum, int endRowNum)
        {
            try
            {
                if (startRowNum < 0) return null;
                if (sourceDt.Rows.Count < endRowNum) endRowNum = sourceDt.Rows.Count;

                DataTable resultDt = sourceDt.Clone();
                DataRow[] rows = sourceDt.Select();
                for (int i = startRowNum; i <= endRowNum; i++)
                {
                    resultDt.ImportRow((DataRow)rows[i]);
                }
                return resultDt;

            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        public  static DataTable GetTableByFieldNames(DataTable sourceDt, List<string> fieldNames, List<string> fieldNames1)
        {
            try
            {
                DataTable resultDt = sourceDt.Copy();
                foreach (DataColumn dc in sourceDt.Columns)
                {
                    if (fieldNames.Contains(dc.ColumnName)) continue; //保留指定列数据
                    if (fieldNames1.Contains(dc.ColumnName)) continue; //保留指定列数据
                    resultDt.Columns.Remove(resultDt.Columns[dc.ColumnName]);
                }
                return resultDt;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

       public static System.Data.DataTable ConvertFieldToType(System.Data.DataTable sourceDt, string fieldName, string fieldName1, FieldValueType fieldType, FieldValueType fieldType1)
        {
            try
            {
                if (fieldType == FieldValueType.非值文本) return null;
                if (!sourceDt.Columns.Contains(fieldName))
                {
                    MessageBox.Show("源表中未找到名为：" + fieldName + "的列");
                    return null;
                }
                if (fieldType == FieldValueType.整数 || fieldType == FieldValueType.小数) return sourceDt;


                //当字段值是整数型文本或小数型文本时，执行字段值对应转换
                DataTable resultDt = sourceDt.Copy();
                resultDt.Columns.Remove(fieldName); //先删掉该列， 防止与新添加列同名冲突
                //根据待转换字段的类型，进行相应的转换
                if (fieldType == FieldValueType.整数文本)
                {
                    resultDt.Columns.Add(fieldName, typeof(int));
                    for (int i = 0; i < resultDt.Rows.Count; i++)
                    {
                        try
                        {
                            resultDt.Rows[i][fieldName] = Convert.ToInt32(sourceDt.Rows[i][fieldName]);
                        }
                        catch (System.Exception ex)
                        {
                            continue;
                        }
                    }
                }
                else if (fieldType == FieldValueType.小数文本)
                {
                    resultDt.Columns.Add(fieldName, typeof(double));
                    for (int i = 0; i < resultDt.Rows.Count; i++)
                    {
                        try
                        {
                            //将对应字段从文本转换为值
                            resultDt.Rows[i][fieldName] = Convert.ToDouble(sourceDt.Rows[i][fieldName]);
                        }
                        catch (System.Exception ex)
                        {
                            continue;
                        }
                    }
                }
                else
                    return null;

                return resultDt;

            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        internal static FieldValueType GetFieldType(System.Data.DataTable sourceDt, string fieldName)
        {
           try
            {
                if (sourceDt == null || sourceDt.Rows.Count == 0)
                    return FieldValueType.非值文本;

                //只需要判断第一行指定列是否为数值即可
                object oneValue = sourceDt.Rows[0][fieldName];
                if (oneValue is int)
                {
                    return FieldValueType.整数;
                }
                else if (oneValue is double)
                {
                    return FieldValueType.小数;
                }

                int outValue1;
                double outValue2;
                bool canParseToInt = int.TryParse(oneValue.ToString(), out outValue1);
                bool canParseToDouble = double.TryParse(oneValue.ToString(), out outValue2);

                if (canParseToInt)
                {
                    return FieldValueType.整数文本;
                }
                if (canParseToDouble)
                {
                    return FieldValueType.小数文本;
                }

                return FieldValueType.非值文本;
            }
            catch (System.Exception ex)
            {
                return FieldValueType.非值文本;
            }
        }

        public static DataTable GetTableByFieldNamesAndRowNumRange2(DataTable sourceDt, List<string> fieldNames1, List<string> fieldNames2, List<string> fieldNames3, List<string> fieldNames4, int startRowNum, int endRowNum)
        {
            DataTable tempDt = GetTableByFieldNames2(sourceDt, fieldNames1, fieldNames2, fieldNames3, fieldNames4); //筛选指定列
            DataTable resultDt = GetTableByRowNumRange(tempDt, startRowNum, endRowNum);//筛选指定行

            return resultDt;
        }

        public static DataTable GetTableByFieldNames2(DataTable sourceDt, List<string> fieldNames1, List<string> fieldNames2, List<string> fieldNames3, List<string> fieldNames4)
        {
            try
            {
                DataTable resultDt = sourceDt.Copy();
                foreach (DataColumn dc in sourceDt.Columns)
                {
                    if (fieldNames1.Contains(dc.ColumnName) || fieldNames2.Contains(dc.ColumnName) || fieldNames3.Contains(dc.ColumnName) || fieldNames4.Contains(dc.ColumnName)) continue; //保留指定列数据
                 
                    resultDt.Columns.Remove(resultDt.Columns[dc.ColumnName]);
                }
                return resultDt;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        public static DataTable ConvertFieldToType2(System.Data.DataTable sourceDt, string fieldName1, string fieldName2,string fieldName3, string fieldName4, FieldValueType yFieldType1, FieldValueType yFieldType2, FieldValueType yFieldType3, FieldValueType yFieldType4)
        {
            try
            {
                if (yFieldType1 == FieldValueType.非值文本 || yFieldType2 == FieldValueType.非值文本) return null;
                if (yFieldType3 == FieldValueType.非值文本 || yFieldType4 == FieldValueType.非值文本) return null;
                if (!sourceDt.Columns.Contains(fieldName1) || !sourceDt.Columns.Contains(fieldName2) || !sourceDt.Columns.Contains(fieldName3) || !sourceDt.Columns.Contains(fieldName4))
                {
                    MessageBox.Show("源表中未找到该列");
                    return null;
                }
                if (yFieldType1 == FieldValueType.整数 || yFieldType1 == FieldValueType.小数) return sourceDt;
                if (yFieldType2== FieldValueType.整数 || yFieldType2 == FieldValueType.小数) return sourceDt;
                if (yFieldType3 == FieldValueType.整数 || yFieldType3 == FieldValueType.小数) return sourceDt;
                if (yFieldType4 == FieldValueType.整数 || yFieldType4 == FieldValueType.小数) return sourceDt;
                //当字段值是整数型文本或小数型文本时，执行字段值对应转换
                DataTable resultDt = sourceDt.Copy();
                resultDt.Columns.Remove(fieldName1); //先删掉该列， 防止与新添加列同名冲突
                resultDt.Columns.Remove(fieldName2);
                resultDt.Columns.Remove(fieldName3);
                resultDt.Columns.Remove(fieldName4); 
                //根据待转换字段的类型，进行相应的转换
                if (yFieldType1 == FieldValueType.整数文本 || yFieldType2 == FieldValueType.整数文本 || yFieldType3 == FieldValueType.整数文本 || yFieldType4 == FieldValueType.整数文本)
                {
                    resultDt.Columns.Add(fieldName1, typeof(int));
                    for (int i = 0; i < resultDt.Rows.Count; i++)
                    {
                        try
                        {
                            resultDt.Rows[i][fieldName1] = Convert.ToInt32(sourceDt.Rows[i][fieldName1]);
                            resultDt.Rows[i][fieldName2] = Convert.ToInt32(sourceDt.Rows[i][fieldName2]);
                            resultDt.Rows[i][fieldName3] = Convert.ToInt32(sourceDt.Rows[i][fieldName3]);
                            resultDt.Rows[i][fieldName4] = Convert.ToInt32(sourceDt.Rows[i][fieldName4]);
                        }
                        catch (System.Exception ex)
                        {
                            continue;
                        }
                    }
                }
                else if (yFieldType1 == FieldValueType.小数文本 || yFieldType2 == FieldValueType.小数文本 || yFieldType4 == FieldValueType.小数文本 || yFieldType3 == FieldValueType.小数文本)
                {
                    resultDt.Columns.Add(fieldName1, typeof(double));
                    resultDt.Columns.Add(fieldName2, typeof(double));
                    resultDt.Columns.Add(fieldName3, typeof(double));
                    resultDt.Columns.Add(fieldName4, typeof(double));
                    for (int i = 0; i < resultDt.Rows.Count; i++)
                    {
                        try
                        {
                            //将对应字段从文本转换为值
                            resultDt.Rows[i][fieldName1] = Convert.ToDouble(sourceDt.Rows[i][fieldName1]);
                            resultDt.Rows[i][fieldName2] = Convert.ToDouble(sourceDt.Rows[i][fieldName2]);
                            resultDt.Rows[i][fieldName3] = Convert.ToDouble(sourceDt.Rows[i][fieldName3]);
                            resultDt.Rows[i][fieldName4] = Convert.ToDouble(sourceDt.Rows[i][fieldName4]);
                        }
                        catch (System.Exception ex)
                        {
                            continue;
                        }
                    }
                }
                else
                    return null;

                return resultDt;

            }
            catch (System.Exception ex)
            {
                return null;
            }
            
        }
    }

       

    public enum FieldValueType
    {
        非值文本 = 0,
        整数文本 = 1,
        小数文本 = 2,
        整数 = 3,
        小数 = 4
    }
}
