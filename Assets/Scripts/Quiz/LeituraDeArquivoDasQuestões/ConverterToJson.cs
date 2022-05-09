using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe que converte o dado em um JSON
/// </summary>
public class ConverterToJson
{
    public string Convert(QuestionAndAnswer data)
    {
        return JsonUtility.ToJson(data);
    }
}
