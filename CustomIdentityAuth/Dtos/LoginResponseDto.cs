using CustomIdentityAuth.Models;

namespace CustomIdentityAuth.Dtos;

public class LoginResponseDto
{
    public AuthTokenDto? AuthTokenDto { get; set; }
}