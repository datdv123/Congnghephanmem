﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NguoiDung
{
   
    public string TenDangNhap { get; set; }
    public string MatKhau { get; set; }
    public string HoTen { get; set; }       
    public int TrangThai { get; set; }
    public NguoiDung()
    {

    }
    public NguoiDung(string tenDangNhap, string matKhau)
    {
        TenDangNhap = tenDangNhap;
        MatKhau = matKhau;
    }
    public NguoiDung(string tenDangNhap, string matKhau, string hoTen)
    {
        TenDangNhap = tenDangNhap;
        MatKhau = matKhau;
        HoTen = hoTen;                
    }
    public NguoiDung(string tenDangNhap, string matKhau, string hoTen, int trangThai)
    {        
        TenDangNhap = tenDangNhap;
        MatKhau = matKhau;
        HoTen = hoTen;      
        TrangThai = trangThai;
    }
}
