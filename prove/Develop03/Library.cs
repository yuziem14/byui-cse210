public class Library {
    private List<Scripture> _scriptures = [];

    public Library() {
        _scriptures = MakeLibrary();
    }

    private List<Scripture> MakeLibrary() {
        List<Scripture> scriptures = [];

        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        scriptures.Add(new Scripture(new Reference("Alma", 26, 22), "Yea, he that repenteth and exerciseth faith, and bringeth forth good works, and prayeth continually without ceasing—unto such it is given to know the mysteries of God; yea, unto such it shall be given to reveal things which never have been revealed; yea, and it shall be given unto such to bring thousands of souls to repentance, even as it has been given unto us to bring these our brethren to repentance."));
        scriptures.Add(new Scripture(new Reference("3 Nephi", 11, 10, 11), "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning."));
        scriptures.Add(new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."));

        return scriptures;
    }

    public Scripture GetRandomScripture() {
        int randomIndex = new Random().Next(0, _scriptures.Count());

        return _scriptures.ElementAt(randomIndex);
    }
} 