namespace test2;

    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }





//Director: Director chịu trách nhiệm thực hiện các bước build theo một trình tự xác định cụ thể
//Class Director là tùy chọn để có Client có thể kiểm soát trực tiếp quá trình.
// Chịu trách nhiệm quản lý quá trình xây dựng đối tượng Product.
// Có một đối tượng IBuilder để thực hiện các bước xây dựng cụ thể.
// Cung cấp các phương thức BuildMinimalViableProduct và BuildFullFeaturedProduct để hướng dẫn builder xây dựng đối tượng Product.

// Director Class:
// Director chịu trách nhiệm quản lý quá trình xây dựng đối tượng Product.
// Có một thuộc tính (Builder) để lưu trữ đối tượng IBuilder được sử dụng để xây dựng Product.
// Cung cấp phương thức BuildMinimalViableProduct để hướng dẫn builder xây dựng phiên bản đối tượng Product tối thiểu.
// Cung cấp phương thức BuildFullFeaturedProduct để hướng dẫn builder xây dựng phiên bản đối tượng Product đầy đủ tính năng. 
// Đối với ví dụ này, nó gọi các phương thức BuildPartA, BuildPartB, và BuildPartC trên đối tượng IBuilder.