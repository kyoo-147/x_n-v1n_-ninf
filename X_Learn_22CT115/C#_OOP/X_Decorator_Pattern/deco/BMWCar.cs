using System;
// BMWCar: ConcreteComponent
// Là một loại Car cụ thể (ConcreteComponent) triển khai giao diện ICar.
// Có các thuộc tính như Than_Xe, Cua_Xe, Banh_Xe, Guong_Xe, và Dong_Co.
// Cài đặt phương thức ManufactureCar() để cung cấp thông tin về việc sản xuất BMWCar.

namespace deco;

    public class BMWCar:ICar
    {
        private string Ten_Xe = "BMW";
        public string Than_Xe { get; set; }
        public string Cua_Xe { get; set; }
        public string Banh_Xe { get; set; }
        public string Guong_Xe { get; set; }
        public string Dong_Co { get; set; }
        public override string ToString()
        {
            return "BMWCar [Ten_Xe=" + Ten_Xe + ", Than_Xe=" + Than_Xe + ", Cua_Xe=" + Cua_Xe + ", Banh_Xe="
                            + Banh_Xe + ", Guong_Xe=" + Guong_Xe + ", Dong_Co=" + Dong_Co + "]";
        }
        public ICar ManufactureCar()
        {
            Than_Xe = "chất liệu carbon";
            Cua_Xe = "4 cửa xe";
            Banh_Xe = "4 bánh xe MRF";
            Guong_Xe = "6 gương xe";
            return this;
        }
    }   
