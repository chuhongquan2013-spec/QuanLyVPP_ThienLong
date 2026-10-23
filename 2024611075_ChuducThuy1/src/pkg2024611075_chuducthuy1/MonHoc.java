/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pkg2024611075_chuducthuy1;

/**
 *
 * @author chu Duc Thuy
 */
import java.util.Scanner;

public class MonHoc implements IO {
    private String maMon;
    private String tenMon;
    private int soTinChi;
    private LoaiMon loaiMon;

    public MonHoc() {}

    public MonHoc(String maMon, String tenMon, int soTinChi, LoaiMon loaiMon) {
        this.maMon = maMon;
        this.tenMon = tenMon;
        this.soTinChi = soTinChi;
        this.loaiMon = loaiMon;
    }

    // input
    @Override
    public void inputData() {
        Scanner sc = new Scanner(System.in);

        System.out.print("Nhập mã môn: ");
        maMon = sc.nextLine();

        System.out.print("Nhập tên môn: ");
        tenMon = sc.nextLine();

        System.out.print("Nhập số tín chỉ: ");
        soTinChi = Integer.parseInt(sc.nextLine());

        System.out.print("Loại môn (1: Cơ sở, 2: Chuyên ngành): ");
        int chon = Integer.parseInt(sc.nextLine());

        if (chon == 1) loaiMon = LoaiMon.CO_SO;
        else loaiMon = LoaiMon.CHUYEN_NGANH;
    }

    // output
    @Override
    public void outputData() {
        System.out.printf("%-10s %-20s %-10d %-15s\n",
                maMon, getTenMon(), soTinChi, loaiMon);
    }

    // getTenMon viết hoa
    public String getTenMon() {
        return tenMon.toUpperCase();
    }

    public int getSoTinChi() {
        return soTinChi;
    }
}
