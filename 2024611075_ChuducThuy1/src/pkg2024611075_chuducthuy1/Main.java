/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package pkg2024611075_chuducthuy1;

/**
 *
 * @author chu Duc Thuy
 */
public class Main {
    public static void main(String[] args) {
        MonHocControl control = new MonHocControl();

        // tạo dữ liệu mẫu
        control.fakeData();

        // in danh sách
        System.out.println("Danh sách môn học:");
        control.outputList();

        // tìm max
        MonHoc max = control.findMax();
        System.out.println("\nMôn có tín chỉ lớn nhất:");
        if (max != null) {
            max.outputData();
        }

        // thêm môn mới
        MonHoc m = new MonHoc();
        m.inputData();
        control.addMore(m);

        System.out.println("\nSau khi thêm:");
        control.outputList();
        
    }
}