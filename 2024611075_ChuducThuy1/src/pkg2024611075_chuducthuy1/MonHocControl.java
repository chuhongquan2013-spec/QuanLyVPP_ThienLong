/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pkg2024611075_chuducthuy1;

/**
 *
 * @author chu Duc Thuy
 */
import java.util.ArrayList;

public class MonHocControl {
    private ArrayList<MonHoc> list = new ArrayList<>();

    // thêm môn
    public void addMore(MonHoc m) {
        list.add(m);
    }

    // in danh sách
    public void outputList() {
        System.out.printf("%-10s %-20s %-10s %-15s\n",
                "Ma", "Ten", "TinChi", "Loai");

        for (MonHoc m : list) {
            m.outputData();
        }
    }

    // fake data
    public void fakeData() {
        list.add(new MonHoc("MH01", "Lap trinh", 3, LoaiMon.CO_SO));
        list.add(new MonHoc("MH02", "CTDL", 4, LoaiMon.CHUYEN_NGANH));
        list.add(new MonHoc("MH03", "Mang", 2, LoaiMon.CO_SO));
    }

    // tìm max tín chỉ
    public MonHoc findMax() {
        if (list.isEmpty()) return null;

        MonHoc max = list.get(0);
        for (MonHoc m : list) {
            if (m.getSoTinChi() > max.getSoTinChi()) {
                max = m;
            }
        }
        return max;
    }
}
