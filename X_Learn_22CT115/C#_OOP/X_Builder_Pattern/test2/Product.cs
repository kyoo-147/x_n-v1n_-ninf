namespace test2;

public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "Bộ phận sản phẩm: " + str + "\n";
        }
    }







//Product: Chỉ sử dụng Builder Pattern khi sản phẩm có nhiều loại và trở nên phức tạp và cần có tỉnh mở rộng.
//Vì đôi khi Concrete builder khác nhau có thể tạo ra những product khác nhau và không liên quan đến nhau.   
// Chứa các phần khác nhau của đối tượng cần xây dựng.
// Cung cấp phương thức Add để thêm các phần vào danh sách.
// Cung cấp phương thức ListParts để hiển thị thông tin về các phần của đối tượng Product.

// Product Class:
// Product là đối tượng cần được xây dựng bước từ bước thông qua Builder Pattern.
// Có một danh sách _parts để lưu trữ các phần khác nhau của đối tượng.
// Phương thức Add được sử dụng để thêm một phần mới vào danh sách _parts.
// Phương thức ListParts được sử dụng để hiển thị thông tin về các phần của đối tượng, chẳng hạn như tên các phần đã được thêm vào.
