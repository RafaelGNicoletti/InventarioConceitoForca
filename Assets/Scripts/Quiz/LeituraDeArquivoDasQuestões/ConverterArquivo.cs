using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe para converter de um arquivo de texto em JSON para a classe ClassPergunta
/// </summary>
public class ConverterArquivo : MonoBehaviour
{
    public ClassPergunta temp;
    public Perguntas perguntas;
    public TextAsset file;

    void Start()
    {
        // Cria o conversor
        ConverterFromJson<ClassPergunta> converter = new ConverterFromJson<ClassPergunta>();
        // Converte o arquivo
        temp = converter.Convert(file);
        // Guarda no objeto
        perguntas.SetQuizQuestions(temp);
    }

    public void LerJson()
    {
        // Cria o conversor
        ConverterFromJson<ClassPergunta> converter = new ConverterFromJson<ClassPergunta>();
        // Converte o arquivo
        temp = converter.Convert(file);
        // Guarda no objeto
        perguntas.SetQuizQuestions(temp);
    }

    public void SalvarJson(List<QuestionAndAnswer> dados, float qualitativo)
    {
        ConverterToJson converter = new ConverterToJson();
        string tempData = "";
        foreach (QuestionAndAnswer question in dados)
        {
            tempData += "\n" + converter.Convert(question);
        }

        tempData += "\nQualitativo " + qualitativo.ToString();

        string filename = "/Dados-" + System.DateTime.Now.ToOADate() + ".json";

        //string filename = "/Dados-" + System.DateTime.Now.Day + "-" + System.DateTime.Now.Month + "-" + System.DateTime.Now.Year + "-" + System.DateTime.Now.TimeOfDay + ".json";

        System.IO.File.WriteAllText(Application.persistentDataPath + filename, tempData);
    }
}
