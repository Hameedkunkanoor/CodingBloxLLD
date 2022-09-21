using CodingBloxLLD.Enums;
using CodingBloxLLD.Models;
using CodingBloxLLD.Services.Implementations;

UserService userService = new UserService();
userService.CreateUser(new User("IronMan", "iron@gmail.com", 1500));
userService.CreateUser(new User("Wanda", "Wanda@gmail.com", 1500));
userService.CreateUser(new User("Loki", "Loki@gmail.com", 1500));
QuestionService questionService = new QuestionService();
questionService.CreateQuestion(new Question("q1", QuestionLevelEnum.Low, 5));
questionService.CreateQuestion(new Question("q2", QuestionLevelEnum.High, 20));
questionService.CreateQuestion(new Question("q3", QuestionLevelEnum.Medium, 10));
questionService.CreateQuestion(new Question("q4", QuestionLevelEnum.High, 15));

questionService.ListQuestion(QuestionLevelEnum.Low);
ContestService contestService = new ContestService();
contestService.CreateContest(new Contest("Endgame", ContestLevelEnum.Low, "Wanda"));

contestService.ListContest(ContestLevelEnum.High);

contestService.AttendContest(1, "Loki");
