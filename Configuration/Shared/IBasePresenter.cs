﻿using BaseApiNet6.Model.Dtos.Response;

namespace BaseApiNet6.Configuration.Shared;

public interface IBasePresenter<T>
{
    ResponseDto<T>? GetResponse { get; set; } // Propiedad para encapsular respuestas

    void Success(T data, string message = "Data retrieved successfully"); // Caso exitoso

    void NotFound(string message = "Data not found"); // Caso de no encontrado

    void Error(string message); // Caso de error
}