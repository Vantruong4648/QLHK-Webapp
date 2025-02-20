# QLHK-Webapp
 Quan LY Hen Kham ASP.NET

* Hướng dẫn chạy project.
1. Mở project bang visual studio 2022
2. Vào menu View > Sql server object explorer
3. Tạo một database mới và copy chuỗi kết nối database.
4. mở file appsettings.json trong project và thay thế chuỗi kết nối ở phần: DefaultConnection
5. Vào Tools > Nuget Package Manager  > Package manager console
6. Chạy lệnh: update-database để khởi tạo database
7. chạy project