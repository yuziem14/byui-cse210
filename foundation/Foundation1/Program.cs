using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("Von Neumann Architecture", "Computerphile", 979));
        videos[0].AddComment(new Comment("Robin Bart", "I love the Computerphile segments"));
        videos[0].AddComment(new Comment("Jim D. Gartner", "This is absolutely amazing"));
        videos[0].AddComment(new Comment("Clark Kent", "I have never heard a more complete and concise explanation"));

        videos.Add(new Video("Registers & RAM", "CrashCourse", 737));
        videos[1].AddComment(new Comment("RedHat Dev", "Now I know how RAM actually stores bits"));
        videos[1].AddComment(new Comment("Ross Newman", "Great content"));
        videos[1].AddComment(new Comment("Jorge Ballard", "This is an absolutely incredible way to teach computing"));
        videos[1].AddComment(new Comment("@computingman", "I've been trying to learn that for ages. Thanks!"));

        videos.Add(new Video("before you code, learn how computers work", "Low Level", 424));
        videos[2].AddComment(new Comment("@first_bit", "If C is not low level, Python is raw English"));
        videos[2].AddComment(new Comment("Alan Turing", "You can learn C in less than a week, but pointers might take a lifetime."));
        videos[2].AddComment(new Comment("Jorge Ballard", "C is a layer directly on top of assembler, and is best approached on this basis."));
        videos[2].AddComment(new Comment("Ryan Charles", "This channel is a gold mine"));
        videos[2].AddComment(new Comment("@AssembleProgrammer", "Before you computer, learn how electricity works"));

        videos.ForEach(v => {
            Console.WriteLine(v.Display());
            Console.WriteLine("Comments");
            Console.Write(v.DisplayComments());
            Console.WriteLine();
            Console.WriteLine();
        });
    }
}