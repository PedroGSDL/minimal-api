using MinimalAPI.Dominio.Entidades;
using MinimalApi.DTOs;


namespace MinimalAPI.Dominio.Interfaces;

public interface iAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
}