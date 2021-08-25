// using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool {
    private List<(string, int)> School { get; set; }

    public GradeSchool() {
        School = new();
    }

    public void Add(string student, int grade) {
        School.Add((student, grade));
    }

    public IEnumerable<string> Roster() {
        var students = School.OrderBy(_ => _.Item1).OrderBy(_ => _.Item2).ToList();

        return students.Select(_ => _.Item1).ToList();
    }

    public IEnumerable<string> Grade(int grade) {
        var students = School.OrderBy(_ => _.Item1).Where(_ => _.Item2 == grade).ToList();

        return students.Select(_ => _.Item1).ToList();
    }
}
