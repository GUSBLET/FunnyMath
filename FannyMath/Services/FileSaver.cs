using FannyMath.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Formats.Asn1.AsnWriter;

namespace FannyMath.Services;

public class FileSaver
{
    public void SaveResult(ScoreOfUser scoreOfUser)
    {
        
        using (StreamWriter writer = File.CreateText("score.json"))
        {
            string output = JsonConvert.SerializeObject(scoreOfUser);
            writer.Write(output);
        }
    }

    public ScoreOfUser ReadScore()
    {
        if (File.Exists("score.json"))
        {
            using (StreamReader reader = File.OpenText("score.json"))
            {
                var fileText = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<ScoreOfUser>(fileText);
            }
        }
        return null;
    }

    public ScoreOfUser EmptyObjectGeneration()
    {
        return new ScoreOfUser()
        {
            MathTaskScore = new MathTaskScore
            {
                HardMode = Enums.HardMode.VeryEasy,
                Score = 0
            },
            TugOfWarScore = new TugOfWarScore
            {
                HardMode = Enums.HardMode.VeryEasy,
                Score = 0
            },
            EquationScoreModel = new EquationScoreModel
            {
                HardMode = Enums.HardMode.VeryEasy,
                Score = 0
            }
        };
    }
}
