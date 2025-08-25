using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

public class AuthService : AuthenticationStateProvider
{
    private NguoiDungDangNhap? _nguoiDung;

    public event Action? OnChange;

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        ClaimsIdentity identity = _nguoiDung != null
            ? new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, _nguoiDung.HoTen),
                new Claim(ClaimTypes.Email, _nguoiDung.Email ?? ""),
                new Claim(ClaimTypes.Role, _nguoiDung.VaiTroString)
            }, "CustomAuth")
            : new ClaimsIdentity();

        return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));
    }

    public Task DangNhap(string email, string hoTen, int maVaiTro, int maNguoiDung)
    {
        _nguoiDung = new NguoiDungDangNhap
        {
            Email = email,
            HoTen = hoTen,
            VaiTro = maVaiTro,
            MaNguoiDung = maNguoiDung // ✅ thêm dòng này
        };
        NotifyStateChanged();
        return Task.CompletedTask;
    }

    public Task DangXuat()
    {
        _nguoiDung = null;
        NotifyStateChanged();
        return Task.CompletedTask;
    }

    private void NotifyStateChanged()
    {
        OnChange?.Invoke();
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public NguoiDungDangNhap? GetCurrent() => _nguoiDung;
    public bool DaDangNhap => _nguoiDung != null;
    public bool LaAdmin => _nguoiDung?.VaiTro == 1;

    public class NguoiDungDangNhap
    {
        public string Email { get; set; } = "";
        public string HoTen { get; set; } = "";
        public int VaiTro { get; set; } = 2;
        public string VaiTroString => VaiTro == 1 ? "Admin" : "Customer";

        // ✅ Thêm thuộc tính MaNguoiDung để đồng bộ với DB
        public int MaNguoiDung { get; set; }
    }
}
