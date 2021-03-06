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

    //public void SalvarJson(QuestionAndAnswer dados)
    //{
    //    ConverterToJson converter = new ConverterToJson();
    //    string tempData = Converter.ConverterToJson(dados);
    //    System.IO.File.WriteAllText(Application.persistentDataPath + "/Dados.json", tempData);
    //}
}
