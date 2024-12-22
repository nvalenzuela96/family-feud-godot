using FamilyFeud;
using Godot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public partial class Board : Node2D
{
    TextureRect cover1;
    TextureRect cover2;
    TextureRect cover3;
    TextureRect cover4;
    TextureRect cover5;
    TextureRect cover6;
    TextureRect cover7;
    TextureRect cover8;

    Label question;

    Label answerScore1;
    Label answerScore2;
    Label answerScore3;
    Label answerScore4;
    Label answerScore5;
    Label answerScore6;
    Label answerScore7;
    Label answerScore8;

    Label answer1;
    Label answer2;
    Label answer3;
    Label answer4;
    Label answer5;
    Label answer6;
    Label answer7;
    Label answer8;

    AudioStreamPlayer correct;
    AudioStreamPlayer incorrect;

    Timer xTimer;

    Sprite2D x1;
    Sprite2D x2;
    Sprite2D x3;

    Label score;
    int runningScore = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        cover1 = GetNode<TextureRect>("Cover1");
        cover2 = GetNode<TextureRect>("Cover2");
        cover3 = GetNode<TextureRect>("Cover3");
        cover4 = GetNode<TextureRect>("Cover4");
        cover5 = GetNode<TextureRect>("Cover5");
        cover6 = GetNode<TextureRect>("Cover6");
        cover7 = GetNode<TextureRect>("Cover7");
        cover8 = GetNode<TextureRect>("Cover8");

        question = GetNode<Label>("Question");

        answer1 = GetNode<Label>("AnswerCol1/Answer1");
        answer2 = GetNode<Label>("AnswerCol1/Answer2");
        answer3 = GetNode<Label>("AnswerCol1/Answer3");
        answer4 = GetNode<Label>("AnswerCol1/Answer4");
        answer5 = GetNode<Label>("AnswerCol2/Answer1");
        answer6 = GetNode<Label>("AnswerCol2/Answer2");
        answer7 = GetNode<Label>("AnswerCol2/Answer3");
        answer8 = GetNode<Label>("AnswerCol2/Answer4");

        answerScore1 = GetNode<Label>("ScoreCol1/Score1");
        answerScore2 = GetNode<Label>("ScoreCol1/Score2");
        answerScore3 = GetNode<Label>("ScoreCol1/Score3");
        answerScore4 = GetNode<Label>("ScoreCol1/Score4");
        answerScore5 = GetNode<Label>("ScoreCol2/Score1");
        answerScore6 = GetNode<Label>("ScoreCol2/Score2");
        answerScore7 = GetNode<Label>("ScoreCol2/Score3");
        answerScore8 = GetNode<Label>("ScoreCol2/Score4");

        x1 = GetNode<Sprite2D>("X1");
        x2 = GetNode<Sprite2D>("X2");
        x3 = GetNode<Sprite2D>("X3");

        xTimer = GetNode<Timer>("XTimer");

        correct = GetNode<AudioStreamPlayer>("CorrectSound");
        incorrect = GetNode<AudioStreamPlayer>("IncorrectSound");

        score = GetNode<Label>("Score");
	}

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event is InputEventKey)
        {
            if (Input.IsActionJustPressed("answer_1"))
            {
                if (cover1.Visible == true)
                {
                    cover1.ZIndex = -1;
                    correct.Play();
                    var pointsScored = answerScore1.Text.ToInt();
                    runningScore += pointsScored;
                }
            }
            if (Input.IsActionJustPressed("answer_2"))
            {
                if (cover2.Visible == true)
                {
                    cover2.ZIndex = -1;
                    correct.Play();
                    var pointsScored = answerScore2.Text.ToInt();
                    runningScore += pointsScored;
                }
            }
            if (Input.IsActionJustPressed("answer_3"))
            {
                if (cover3.Visible == true)
                {
                    cover3.ZIndex = -1;
                    correct.Play();
                    var pointsScored = answerScore3.Text.ToInt();
                    runningScore += pointsScored;
                }
            }
            if (Input.IsActionJustPressed("answer_4"))
            {
                if (cover4.Visible == true)
                {
                    cover4.ZIndex = -1;
                    correct.Play();
                    var pointsScored = answerScore4.Text.ToInt();
                    runningScore += pointsScored;
                }
            }
            if (Input.IsActionJustPressed("answer_5"))
            {
                if (cover5.Visible == true)
                {
                    cover5.ZIndex = -1;
                    correct.Play();
                    var pointsScored = answerScore5.Text.ToInt();
                    runningScore += pointsScored;
                }
            }
            if (Input.IsActionJustPressed("answer_6"))
            {
                if (cover6.Visible == true)
                {
                    cover6.ZIndex = -1;
                    correct.Play();
                    var pointsScored = answerScore6.Text.ToInt();
                    runningScore += pointsScored;
                }
            }
            if (Input.IsActionJustPressed("answer_7"))
            {
                if (cover7.Visible == true)
                {
                    cover7.ZIndex = -1;
                    correct.Play();
                    var pointsScored = answerScore7.Text.ToInt();
                    runningScore += pointsScored;
                }
            }
            if (Input.IsActionJustPressed("answer_8"))
            {
                if (cover8.Visible == true)
                {
                    cover8.ZIndex = -1;
                    correct.Play();
                    var pointsScored = answerScore8.Text.ToInt();
                    runningScore += pointsScored;
                }
            }
            if (Input.IsActionJustPressed("x_1"))
            {
                x1.Visible = true;
                incorrect.Play();
                xTimer.Start();
            }
            if (Input.IsActionJustPressed("x_2"))
            {
                x1.Visible = true;
                x2.Visible = true;
                incorrect.Play();
                xTimer.Start();
            }
            if (Input.IsActionJustPressed("x_3"))
            {
                x1.Visible = true;
                x2.Visible = true;
                x3.Visible = true;
                incorrect.Play();
                xTimer.Start();
            }
            if (Input.IsActionJustPressed("reset"))
            {
                cover1.ZIndex = 0;
                cover1.Visible = true;
                cover2.ZIndex = 0;
                cover2.Visible = true;
                cover3.ZIndex = 0;
                cover3.Visible = true;
                cover4.ZIndex = 0;
                cover4.Visible = true;
                cover5.ZIndex = 0;
                cover5.Visible = true;
                cover6.ZIndex = 0;
                cover6.Visible = true;
                cover7.ZIndex = 0;
                cover7.Visible = true;
                cover8.ZIndex = 0;
                cover8.Visible = true;

                answer1.Visible = true;
                answer2.Visible = true;
                answer3.Visible = true;
                answer4.Visible = true;
                answer5.Visible = true;
                answer6.Visible = true;
                answer7.Visible = true;
                answer8.Visible = true;

                answerScore1.Visible = true;
                answerScore2.Visible = true;
                answerScore3.Visible = true;
                answerScore4.Visible = true;
                answerScore5.Visible = true;
                answerScore6.Visible = true;
                answerScore7.Visible = true;
                answerScore8.Visible = true;

                runningScore = 0;
            }
            if (Input.IsActionJustPressed("load_1"))
            {
                var fileName = "res://question1.json";
                var jsonString = FileAccess.GetFileAsString(fileName);
                var round = JsonConvert.DeserializeObject<Questions>(jsonString);
                
                question.Text = round.Question;

                answer1.Text = round.Answers[0].Answer;
                answerScore1.Text = round.Answers[0].Points.ToString();

                answer2.Text = round.Answers[1].Answer;
                answerScore2.Text = round.Answers[1].Points.ToString();

                answer3.Text = round.Answers[2].Answer;
                answerScore3.Text = round.Answers[2].Points.ToString();

                answer4.Text = round.Answers[3].Answer;
                answerScore4.Text = round.Answers[3].Points.ToString();

                answer5.Text = round.Answers[4].Answer;
                answerScore5.Text = round.Answers[4].Points.ToString();

                answer6.Text = round.Answers[5].Answer;
                answerScore6.Text = round.Answers[5].Points.ToString();

                answer7.Text = round.Answers[6].Answer;
                answerScore7.Text = round.Answers[6].Points.ToString();

                answer8.Visible = false;
                answerScore8.Visible = false;
                cover8.Visible = false;
            }
            if (Input.IsActionJustPressed("load_2"))
            {
                var fileName = "res://question2.json";
                var jsonString = FileAccess.GetFileAsString(fileName);
                var round = JsonConvert.DeserializeObject<Questions>(jsonString);

                question.Text = round.Question;

                answer1.Text = round.Answers[0].Answer;
                answerScore1.Text = round.Answers[0].Points.ToString();

                answer2.Text = round.Answers[1].Answer;
                answerScore2.Text = round.Answers[1].Points.ToString();

                answer3.Text = round.Answers[2].Answer;
                answerScore3.Text = round.Answers[2].Points.ToString();

                answer4.Text = round.Answers[3].Answer;
                answerScore4.Text = round.Answers[3].Points.ToString();

                answer5.Text = round.Answers[4].Answer;
                answerScore5.Text = round.Answers[4].Points.ToString();

                answer6.Text = round.Answers[5].Answer;
                answerScore6.Text = round.Answers[5].Points.ToString();

                answer7.Visible = false;
                answerScore7.Visible = false;
                cover7.Visible = false;

                answer8.Visible = false;
                answerScore8.Visible = false;
                cover8.Visible = false;
            }
            if (Input.IsActionJustPressed("load_3"))
            {
                var fileName = "res://question3.json";
                var jsonString = FileAccess.GetFileAsString(fileName);
                var round = JsonConvert.DeserializeObject<Questions>(jsonString);

                question.Text = round.Question;

                answer1.Text = round.Answers[0].Answer;
                answerScore1.Text = round.Answers[0].Points.ToString();

                answer2.Text = round.Answers[1].Answer;
                answerScore2.Text = round.Answers[1].Points.ToString();

                answer3.Text = round.Answers[2].Answer;
                answerScore3.Text = round.Answers[2].Points.ToString();

                answer4.Text = round.Answers[3].Answer;
                answerScore4.Text = round.Answers[3].Points.ToString();

                answer5.Text = round.Answers[4].Answer;
                answerScore5.Text = round.Answers[4].Points.ToString();

                answer6.Text = round.Answers[5].Answer;
                answerScore6.Text = round.Answers[5].Points.ToString();

                answer7.Text = round.Answers[6].Answer;
                answerScore7.Text = round.Answers[6].Points.ToString();

                answer8.Text = round.Answers[7].Answer;
                answerScore8.Text = round.Answers[7].Points.ToString();
            }
        }
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
        score.Text = runningScore.ToString();
	}

    public void _OnXTimerTimeout()
    {
        x1.Visible = false;
        x2.Visible = false;
        x3.Visible = false;
    }
}
