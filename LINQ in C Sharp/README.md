# So sánh List<> và INumerable<>
## Type
- IEnumerable<T> là một interface, mà có thể đại diện cho một tập hợp các phần tử có thể được liệt kê. Nó cung cấp một cách để liệt kê qua các phần tử mà không cần biết cấu trúc của tập hợp.
- List<T> là 1 concrete class implements các interface: IEnumerable<Product>, ICollection<Product>, IList<Product>,... 

## Flexibility
- IEnumerable<T> không hỗ trợ thêm, sửa, xóa phần tử. Nó chỉ hỗ trợ duyệt qua các phần tử.
- List<T> hỗ trợ thêm, sửa, xóa phần tử.

## Usage
- IEnumerable<T> thường được sử dụng khi chúng ta muốn truy cập các phần tử một cách tuần tự, không cần biết cấu trúc của tập hợp. IEnumerable<T> dùng khi chỉ muốn tạo 1 **read-only collection**.
- List<T> thường được sử dụng khi chúng ta muốn thêm, sửa, xóa phần tử, truy cập thông qua **index**

## Performance
- IEnumerable<Product> can be more efficient for read-only operations because it does not require the overhead of a list.
- List<Product> may have more overhead due to its additional functionality, but it provides more features for managing the collection.