using EduSphere.Data.Enums;
using EduSphere.Data.Static;
using EduSphere.Models;
using Microsoft.AspNetCore.Identity;

namespace EduSphere.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Companies.Any())
                {
                    context.Companies.AddRange(new List<Company>()
                    {
                        new Company()
                        {
                            Name = "Google",
                            Description = "Organize the world’s information and make it universally accessible and useful.",
                            EmailAddress = "press@google.com",
                            PhoneNumber = "+1-650-253-0000",
                            WebsiteAddress = "https://www.google.com",
                            Address = "1600 Amphitheatre Parkway, Mountain View, CA 94043, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Google_%22G%22_logo.svg/480px-Google_%22G%22_logo.svg.png"
                        },
                        new Company()
                        {
                            Name = "Apple",
                            Description = "Creating the best products on earth, and leaving the world better than we found it.",
                            EmailAddress = "contact@apple.com",
                            PhoneNumber = "+1-800-692-7753",
                            WebsiteAddress = "https://www.apple.com",
                            Address = "One Apple Park Way, Cupertino, CA 95014, USA",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOQmnV_JcXPjgIId3UfkUgBlEkvaZPlcTtqD0qpWXvQA&s"
                        },
                        new Company()
                        {
                            Name = "NASA",
                            Description = "To discover and expand knowledge for the benefit of humanity.",
                            EmailAddress = "public-inquiries@hq.nasa.gov",
                            PhoneNumber = "+1-202-358-0001",
                            WebsiteAddress = "https://www.nasa.gov",
                            Address = "300 E Street SW, Washington, DC 20546, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/NASA_logo.svg/640px-NASA_logo.svg.png"
                        },
                        new Company()
                        {
                            Name = "Microsoft",
                            Description = "Empower every person and every organization on the planet to achieve more.",
                            EmailAddress = "contact@microsoft.com",
                            PhoneNumber = "+1-425-882-8080",
                            WebsiteAddress = "https://www.microsoft.com",
                            Address = "One Microsoft Way, Redmond, WA 98052, USA",
                            Logo = "https://miro.medium.com/v2/resize:fit:1400/1*MxZpRFN3hnZrCC05s1q73A.png"
                        },
                        new Company()
                        {
                            Name = "Harvard University",
                            Description = "Dedicated to excellence in teaching, learning, and research.",
                            EmailAddress = "info@harvard.edu",
                            PhoneNumber = "+1-617-495-1000",
                            WebsiteAddress = "https://www.harvard.edu",
                            Address = "Cambridge, MA 02138, USA",
                            Logo = "https://media.designrush.com/inspiration_images/131656/conversions/_1523460223_965_Harvard-Wreath-Logo_ab2ece9fbd52-mobile.jpg"
                        },
                        new Company()
                        {
                            Name = "University of Oxford",
                            Description = "A world-leading center of learning, teaching, and research.",
                            EmailAddress = "info@ox.ac.uk",
                            PhoneNumber = "+44-1865-270000",
                            WebsiteAddress = "https://www.ox.ac.uk",
                            Address = "Oxford OX1 2JD, United Kingdom",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Oxford-University-Circlet.svg/1636px-Oxford-University-Circlet.svg.png"
                        },
                        new Company()
                        {
                            Name = "Amazon",
                            Description = "Earth’s most customer-centric company.",
                            EmailAddress = "info@amazon.com",
                            PhoneNumber = "+1-206-266-1000",
                            WebsiteAddress = "https://www.amazon.com",
                            Address = "410 Terry Ave N, Seattle, WA 98109, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Amazon_logo.svg/800px-Amazon_logo.svg.png"
                        },
                        new Company()
                        {
                            Name = "Facebook",
                            Description = "Give people the power to build community and bring the world closer together.",
                            EmailAddress = "info@facebook.com",
                            PhoneNumber = "+1-650-543-4800",
                            WebsiteAddress = "https://www.facebook.com",
                            Address = "1 Hacker Way, Menlo Park, CA 94025, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/Facebook_f_logo_%282019%29.svg/800px-Facebook_f_logo_%282019%29.svg.png"
                        },
                        new Company()
                        {
                            Name = "Tesla",
                            Description = "To accelerate the world’s transition to sustainable energy.",
                            EmailAddress = "info@tesla.com",
                            PhoneNumber = "+1-888-518-3752",
                            WebsiteAddress = "https://www.tesla.com",
                            Address = "3500 Deer Creek Road, Palo Alto, CA 94304, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Tesla_Motors.svg/800px-Tesla_Motors.svg.png"
                        },
                        new Company()
                        {
                            Name = "Netflix",
                            Description = "To entertain the world.",
                            EmailAddress = "info@netflix.com",
                            PhoneNumber = "+1-408-540-3700",
                            WebsiteAddress = "https://www.netflix.com",
                            Address = "100 Winchester Circle, Los Gatos, CA 95032, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Netflix_2015_logo.svg/800px-Netflix_2015_logo.svg.png"
                        },
                        new Company()
                        {
                            Name = "Twitter",
                            Description = "To give everyone the power to create and share ideas and information instantly, without barriers.",
                            EmailAddress = "info@twitter.com",
                            PhoneNumber = "+1-415-222-9670",
                            WebsiteAddress = "https://www.twitter.com",
                            Address = "1355 Market Street, Suite 900, San Francisco, CA 94103, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Twitter_bird_logo_2012.svg/800px-Twitter_bird_logo_2012.svg.png"
                        },
                        new Company()
                        {
                            Name = "SpaceX",
                            Description = "To enable humans to become a spacefaring civilization and a multi-planetary species by building a self-sustaining city on Mars.",
                            EmailAddress = "info@spacex.com",
                            PhoneNumber = "+1-310-363-6000",
                            WebsiteAddress = "https://www.spacex.com",
                            Address = "1 Rocket Road, Hawthorne, CA 90250, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/SpaceX_Logo_Black.png/800px-SpaceX_Logo_Black.png"
                        },
                        new Company()
                        {
                            Name = "Adobe",
                            Description = "Changing the world through digital experiences.",
                            EmailAddress = "info@adobe.com",
                            PhoneNumber = "+1-408-536-6000",
                            WebsiteAddress = "https://www.adobe.com",
                            Address = "345 Park Avenue, San Jose, CA 95110-2704, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Adobe_Systems_logo_and_wordmark_%282013%29.svg/800px-Adobe_Systems_logo_and_wordmark_%282013%29.svg.png"
                        },
                        new Company()
                        {
                            Name = "IBM",
                            Description = "To be essential to our clients, to the world.",
                            EmailAddress = "info@ibm.com",
                            PhoneNumber = "+1-800-426-4968",
                            WebsiteAddress = "https://www.ibm.com",
                            Address = "1 New Orchard Road, Armonk, New York 10504-1722, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/IBM_logo.svg/800px-IBM_logo.svg.png"
                        },
                        new Company()
                        {
                            Name = "Toyota",
                            Description = "Moving people and making cars for a better world.",
                            EmailAddress = "info@toyota.com",
                            PhoneNumber = "+1-800-331-4331",
                            WebsiteAddress = "https://www.toyota.com",
                            Address = "Toyota Motor Sales, U.S.A., Inc. 19001 South Western Ave. Dept. WC11 Torrance, CA 90501",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4d/Toyota_Logo.svg/800px-Toyota_Logo.svg.png"
                        },
                        new Company()
                        {
                            Name = "Coca-Cola",
                            Description = "To refresh the world in mind, body, and spirit.",
                            EmailAddress = "info@coca-cola.com",
                            PhoneNumber = "+1-800-438-2653",
                            WebsiteAddress = "https://www.coca-cola.com",
                            Address = "The Coca-Cola Company, P.O. Box 1734, Atlanta, GA 30301, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Coca-Cola_logo.svg/800px-Coca-Cola_logo.svg.png"
                        },
                        new Company()
                        {
                            Name = "Nike",
                            Description = "To bring inspiration and innovation to every athlete in the world.",
                            EmailAddress = "info@nike.com",
                            PhoneNumber = "+1-503-671-6453",
                            WebsiteAddress = "https://www.nike.com",
                            Address = "Nike World Headquarters, One Bowerman Drive, Beaverton, OR 97005, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Logo_NIKE.svg/800px-Logo_NIKE.svg.png"
                        },
                        new Company()
                        {
                            Name = "Walt Disney",
                            Description = "To entertain, inform and inspire people around the globe through the power of unparalleled storytelling, reflecting the iconic brands, creative minds and innovative technologies.",
                            EmailAddress = "info@disney.com",
                            PhoneNumber = "+1-818-560-1000",
                            WebsiteAddress = "https://www.disney.com",
                            Address = "500 South Buena Vista Street, Burbank, California 91521, USA",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Walt_Disney_Company_logo_2012.svg/800px-Walt_Disney_Company_logo_2012.svg.png"
                        },
                        new Company()
                        {
                            Name = "Samsung",
                            Description = "Inspire the world, create the future.",
                            EmailAddress = "info@samsung.com",
                            PhoneNumber = "+82-2-2255-0114",
                            WebsiteAddress = "https://www.samsung.com",
                            Address = "Samsung Electronics Building, 129 Samsung-ro, Yeongtong-gu, Suwon-si, Gyeonggi-do, Korea",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Samsung_Logo.svg/800px-Samsung_Logo.svg.png"
                        }
                    });

                    context.SaveChanges();
                }

                if (!context.Teachers.Any())
                {
                    context.Teachers.AddRange(new List<Teacher>()
                    {
                        new Teacher()
                        {
                            FullName = "Ali Akber",
                            Specialization = "Full Stack Master",
                            Biography = "Ali Akber has been a full stack developer for over 10 years. " +
                                        "He has extensive experience working with numerous tech companies and startups. " +
                                        "Ali is known for his expertise in both front-end and back-end development, " +
                                        "ensuring seamless integration and functionality across various platforms. " +
                                        "He is passionate about mentoring junior developers and regularly speaks at tech conferences.",
                            EmailAddress = "ali.akber@techmail.com",
                            PhoneNumber = "+1 (415) 123-4567",
                            ProfilePictureURL = "https://t3.ftcdn.net/jpg/02/22/85/16/360_F_222851624_jfoMGbJxwRi5AWGdPgXKSABMnzCQo9RN.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/aliakber",
                            InstagramProfileUrl = "https://instagram.com/aliakber",
                            FacebookProfileUrl = "https://facebook.com/aliakber"
                        },
                        new Teacher()
                        {
                            FullName = "Elena Wathsa",
                            Specialization = "Frontend Developer",
                            Biography = "Elena Wathsa is a skilled frontend developer with 8 years of experience. " +
                                        "She specializes in creating visually appealing and user-friendly web applications. " +
                                        "Elena is an expert in HTML, CSS, and JavaScript, and has a keen eye for design. " +
                                        "She has worked on a variety of high-profile projects and is dedicated to delivering top-notch user experiences.",
                            EmailAddress = "elena.wathsa@webdev.com",
                            PhoneNumber = "+1 (415) 234-5678",
                            ProfilePictureURL = "https://www.perfocal.com/blog/content/images/size/w960/2021/01/Perfocal_17-11-2019_TYWFAQ_100_standard-3.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/elenawatsha",
                            InstagramProfileUrl = "https://instagram.com/elenawatsha",
                            FacebookProfileUrl = "https://facebook.com/elenawatsha"
                        },
                        new Teacher()
                        {
                            FullName = "Johny Cafush",
                            Specialization = "Backend Developer",
                            Biography = "Johny Cafush has over 7 years of experience in backend development. " +
                                        "He is proficient in various backend technologies and frameworks, " +
                                        "focusing on creating robust and scalable server-side applications. " +
                                        "Johny has a deep understanding of database management, API development, " +
                                        "and system architecture, making him a vital asset to any development team.",
                            EmailAddress = "johny.cafush@backendpro.com",
                            PhoneNumber = "+1 (415) 345-6789",
                            ProfilePictureURL = "https://images.ctfassets.net/h6goo9gw1hh6/2sNZtFAWOdP1lmQ33VwRN3/24e953b920a9cd0ff2e1d587742a2472/1-intro-photo-final.jpg?w=1200&h=992&fl=progressive&q=70&fm=jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/johnycafush",
                            InstagramProfileUrl = "https://instagram.com/johnycafush",
                            FacebookProfileUrl = "https://facebook.com/johnycafush"
                        },
                        new Teacher()
                        {
                            FullName = "Mia Switz",
                            Specialization = "Data Scientist",
                            Biography = "Mia Switz is a data scientist with 5 years of experience in data analysis, " +
                                        "machine learning, and artificial intelligence. She has worked on numerous projects involving " +
                                        "big data and predictive modeling. Mia is passionate about leveraging data to drive decision-making and " +
                                        "has published several papers on machine learning algorithms.",
                            EmailAddress = "mia.switz@datainsights.com",
                            PhoneNumber = "+1 (415) 456-7890",
                            ProfilePictureURL = "https://insightglobal.com/wp-content/uploads/2022/10/headshot-1024x683.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/miaswitz",
                            InstagramProfileUrl = "https://instagram.com/miaswitz",
                            FacebookProfileUrl = "https://facebook.com/miaswitz"
                        },
                        new Teacher()
                        {
                            FullName = "Sam Cruse",
                            Specialization = "AI Specialist",
                            Biography = "Sam Cruse has been at the forefront of artificial intelligence research for over 6 years. " +
                                        "His expertise includes neural networks, deep learning, and AI-driven automation. Sam has contributed to several " +
                                        "open-source AI projects and is a frequent speaker at industry conferences. He is dedicated to advancing AI technology and its applications.",
                            EmailAddress = "sam.cruse@aiexpert.com",
                            PhoneNumber = "+1 (415) 567-8901",
                            ProfilePictureURL = "https://img.freepik.com/free-photo/cheerful-indian-businessman-smiling-closeup-portrait-jobs-career-campaign_53876-129416.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/samcruse",
                            InstagramProfileUrl = "https://instagram.com/samcruse",
                            FacebookProfileUrl = "https://facebook.com/samcruse"
                        },
                        new Teacher()
                        {
                            FullName = "Sarah Jolie",
                            Specialization = "Machine Learning Expert",
                            Biography = "Sarah Jolie is a machine learning expert with over 6 years of experience. " +
                                        "She specializes in developing and implementing machine learning models for various industries. " +
                                        "Sarah has a strong background in computer science and mathematics, and she enjoys teaching others about the potential of machine learning.",
                            EmailAddress = "sarah.jolie@mlpros.com",
                            PhoneNumber = "+1 (415) 678-9012",
                            ProfilePictureURL = "https://images.pexels.com/photos/1310522/pexels-photo-1310522.jpeg?cs=srgb&dl=pexels-george-dolgikh-551816-1310522.jpg&fm=jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/sarahjolie",
                            InstagramProfileUrl = "https://instagram.com/sarahjolie",
                            FacebookProfileUrl = "https://facebook.com/sarahjolie"
                        },
                        new Teacher()
                        {
                            FullName = "Michael Chang",
                            Specialization = "Mobile App Developer",
                            Biography = "Michael Chang is a seasoned mobile app developer with a passion for creating intuitive and engaging user experiences. He has worked on a variety of mobile projects across different platforms and industries, ranging from social networking to e-commerce. Michael stays up-to-date with the latest trends in mobile development and is always eager to experiment with new technologies.",
                            EmailAddress = "michael.chang@mobiledev.com",
                            PhoneNumber = "+1 (415) 123-4567",
                            ProfilePictureURL = "https://t3.ftcdn.net/jpg/02/99/04/20/360_F_299042079_vGBD7wIlSeNl7vOevWHiL93G4koMM967.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/michaelchang",
                            InstagramProfileUrl = "https://instagram.com/michaelchang",
                            FacebookProfileUrl = "https://facebook.com/michaelchang"
                        },
                        new Teacher()
                        {
                            FullName = "Julia Roberts",
                            Specialization = "UI/UX Designer",
                            Biography = "Julia Roberts is a talented UI/UX designer with a flair for creating visually stunning and user-friendly interfaces. She has a keen eye for detail and a passion for understanding user behavior. Julia believes that good design is essential for creating meaningful interactions and strives to deliver exceptional user experiences in every project she undertakes.",
                            EmailAddress = "julia.roberts@uiuxdesign.com",
                            PhoneNumber = "+1 (415) 234-5678",
                            ProfilePictureURL = "https://images.unsplash.com/photo-1438761681033-6461ffad8d80?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8cGVyc29ufGVufDB8fDB8fHww",
                            LinkedinProfileUrl = "https://linkedin.com/in/juliaroberts",
                            InstagramProfileUrl = "https://instagram.com/juliaroberts",
                            FacebookProfileUrl = "https://facebook.com/juliaroberts"
                        },
                        new Teacher()
                        {
                            FullName = "David Kim",
                            Specialization = "Cybersecurity Expert",
                            Biography = "David Kim is a cybersecurity expert with extensive experience in protecting organizations from cyber threats. He specializes in developing robust security solutions and implementing best practices to safeguard sensitive information. David is passionate about educating others on cybersecurity awareness and helping businesses stay one step ahead of potential threats.",
                            EmailAddress = "david.kim@cybersecpro.com",
                            PhoneNumber = "+1 (415) 345-6789",
                            ProfilePictureURL = "https://t3.ftcdn.net/jpg/02/43/12/34/360_F_243123463_zTooub557xEWABDLk0jJklDyLSGl2jrr.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/davidkim",
                            InstagramProfileUrl = "https://instagram.com/davidkim",
                            FacebookProfileUrl = "https://facebook.com/davidkim"
                        },
                        new Teacher()
                        {
                            FullName = "Emily Watson",
                            Specialization = "Digital Marketing Strategist",
                            Biography = "Emily Watson is a digital marketing strategist with a proven track record of driving growth and engagement through innovative campaigns. She specializes in SEO, SEM, and social media marketing, leveraging data-driven insights to optimize marketing performance. Emily is passionate about helping businesses build their online presence and reach their target audience effectively.",
                            EmailAddress = "emily.watson@digitalmarketer.com",
                            PhoneNumber = "+1 (415) 456-7890",
                            ProfilePictureURL = "https://t4.ftcdn.net/jpg/03/83/25/83/360_F_383258331_D8imaEMl8Q3lf7EKU2Pi78Cn0R7KkW9o.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/emilywatson",
                            InstagramProfileUrl = "https://instagram.com/emilywatson",
                            FacebookProfileUrl = "https://facebook.com/emilywatson"
                        },
                        new Teacher()
                        {
                            FullName = "Daniel Lee",
                            Specialization = "Cloud Architect",
                            Biography = "Daniel Lee is a skilled cloud architect with expertise in designing and implementing scalable cloud solutions. He has extensive experience working with major cloud providers such as AWS, Azure, and Google Cloud Platform. Daniel is passionate about leveraging cloud technologies to drive innovation and enhance organizational efficiency.",
                            EmailAddress = "daniel.lee@cloudexpert.com",
                            PhoneNumber = "+1 (415) 567-8901",
                            ProfilePictureURL = "https://t3.ftcdn.net/jpg/03/02/88/46/360_F_302884605_actpipOdPOQHDTnFtp4zg4RtlWzhOASp.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/daniellee",
                            InstagramProfileUrl = "https://instagram.com/daniellee",
                            FacebookProfileUrl = "https://facebook.com/daniellee"
                        },
                        new Teacher()
                        {
                            FullName = "Sophia Martinez",
                            Specialization = "Product Manager",
                            Biography = "Sophia Martinez is a seasoned product manager with a proven track record of successfully launching and managing digital products. She excels at translating customer needs into product requirements and leading cross-functional teams to deliver innovative solutions. Sophia is passionate about creating products that make a positive impact on people's lives.",
                            EmailAddress = "sophia.martinez@productmanager.com",
                            PhoneNumber = "+1 (415) 678-9012",
                            ProfilePictureURL = "https://www.georgetown.edu/wp-content/uploads/2022/02/Jkramerheadshot-scaled-e1645036825432-1050x1050-c-default.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/sophiamartinez",
                            InstagramProfileUrl = "https://instagram.com/sophiamartinez",
                            FacebookProfileUrl = "https://facebook.com/sophiamartinez"
                        },
                        new Teacher()
                        {
                            FullName = "Ryan Johnson",
                            Specialization = "DevOps Engineer",
                            Biography = "Ryan Johnson is a skilled DevOps engineer with expertise in automating and streamlining IT operations. He specializes in implementing continuous integration and deployment pipelines, optimizing infrastructure, and ensuring the reliability and security of applications. Ryan is committed to helping teams deliver high-quality software at speed.",
                            EmailAddress = "ryan.johnson@devopspro.com",
                            PhoneNumber = "+1 (415) 789-0123",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLA994hpL3PMmq0scCuWOu0LGsjef49dyXVg&s",
                            LinkedinProfileUrl = "https://linkedin.com/in/ryanj",
                            InstagramProfileUrl = "https://instagram.com/ryanj",
                            FacebookProfileUrl = "https://facebook.com/ryanj"
                        },
                        new Teacher()
                        {
                            FullName = "Emma Wilson",
                            Specialization = "UX Researcher",
                            Biography = "Emma Wilson is a dedicated UX researcher with a passion for understanding user behavior and improving digital experiences. She employs a variety of research methods, including user interviews, surveys, and usability testing, to gather insights and inform design decisions. Emma is committed to advocating for the user and ensuring that products meet their needs and expectations.",
                            EmailAddress = "emma.wilson@uxresearcher.com",
                            PhoneNumber = "+1 (415) 890-1234",
                            ProfilePictureURL = "https://engineering.unl.edu/images/staff/Kayla-Person.jpg",
                            LinkedinProfileUrl = "https://linkedin.com/in/emmawilson",
                            InstagramProfileUrl = "https://instagram.com/emmawilson",
                            FacebookProfileUrl = "https://facebook.com/emmawilson"
                        }
                    });

                    context.SaveChanges();
                }

                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                            Name = "Data Science",
                            Description = "In this Data Science course, you will learn how to analyze data, build machine learning models, " +
                                          "and make data-driven decisions. The course covers Python programming, statistical analysis, data visualization, and more. Duration: 12 weeks.",
                            Price = 120.00,
                            StartDate = new DateTime(2024, 1, 10),
                            EndDate = new DateTime(2024, 8, 10),
                            CompanyId = 1,
                            CourseCategory = CourseCategory.Development,
                            ImageUrl = "https://www.shutterstock.com/image-photo/lecturer-helps-scholar-project-advising-600nw-2102457295.jpg"
                        },
                        new Course()
                        {
                            Name = "Cryptography",
                            Description = "This Cryptography course teaches the principles of secure communication, encryption algorithms, " +
                                          "and cryptographic protocols. You will understand how to protect information and secure communications. Duration: 8 weeks.",
                            Price = 89.00,
                            StartDate = new DateTime(2024, 4, 15),
                            EndDate = new DateTime(2024, 8, 15),
                            CompanyId = 2,
                            CourseCategory = CourseCategory.Development,
                            ImageUrl = "https://www.odysseytraining.com.au/wp-content/uploads/2020/04/influencing.jpg"
                        },
                        new Course()
                        {
                            Name = "Game Development",
                            Description = "In the Game Development course, you will learn how to design and develop video games. " +
                                          "Topics include game mechanics, 2D and 3D graphics, sound design, and game physics. Duration: 10 weeks.",
                            Price = 150.00,
                            StartDate = new DateTime(2024, 3, 20),
                            EndDate = new DateTime(2024, 7, 20),
                            CompanyId = 3,
                            CourseCategory = CourseCategory.Development,
                            ImageUrl = "https://www.odysseytraining.com.au/wp-content/uploads/2020/04/Effective-People-and-COmms.jpg"
                        },
                        new Course()
                        {
                            Name = "Marketing And Sales",
                            Description = "This Marketing and Sales course covers marketing strategies, consumer behavior, and sales techniques. " +
                                          "You will learn how to create effective marketing campaigns and close sales successfully. Duration: 6 weeks.",
                            Price = 159.00,
                            StartDate = new DateTime(2024, 8, 25),
                            EndDate = new DateTime(2024, 12, 25),
                            CompanyId = 4,
                            CourseCategory = CourseCategory.Marketing,
                            ImageUrl = "https://petroknowledge.com/wp-content/uploads/2024/01/Effective-Corporate-Communication-for-the-Oil-Gas-Industries-image.jpg"
                        },
                        new Course()
                        {
                            Name = "UX/UI Design",
                            Description = "The UX/UI Design course teaches the principles of user experience and user interface design. " +
                                          "You will learn how to create intuitive and aesthetically pleasing interfaces. Topics include user research, " +
                                          "wireframing, prototyping, and usability testing. Duration: 9 weeks.",
                            Price = 99.00,
                            StartDate = new DateTime(2024, 5, 5),
                            EndDate = new DateTime(2024, 9, 5),
                            CompanyId = 5,
                            CourseCategory = CourseCategory.Design,
                            ImageUrl = "https://cdn01.alison-static.net/courses/1415/alison_courseware_intro_1415.jpg"
                        },
                        new Course()
                        {
                            Name = "Java Backend",
                            Description = "In this Java Backend course, you will learn how to build robust and scalable backend systems using Java. " +
                                          "Topics include Spring framework, RESTful APIs, database integration, and microservices architecture. Duration: 14 weeks.",
                            Price = 189.00,
                            StartDate = new DateTime(2024, 7, 1),
                            EndDate = new DateTime(2024, 10, 1),
                            CompanyId = 6,
                            CourseCategory = CourseCategory.Development,
                            ImageUrl = "https://cocollaborative.org.uk/wp-content/uploads/2021/10/Post-image-The-Benefits-of-Attending-Community-Development-Courses-Learning-and-Mastering-a-Range-of-New-Life-Skills.jpg"
                        },
                        ////////////////
                        new Course()
                        {
                            Name = "Mobile App Development",
                            Description = "In this Mobile App Development course, you will learn how to design and develop mobile applications for iOS and Android platforms. Topics include app architecture, user interface design, data storage, and app deployment. Duration: 12 weeks.",
                            Price = 169.00,
                            StartDate = new DateTime(2024, 6, 10),
                            EndDate = new DateTime(2024, 10, 10),
                            CompanyId = 7,
                            CourseCategory = CourseCategory.Development,
                            ImageUrl = "https://trafford.tscg.ac.uk/wp-content/uploads/sites/2/2021/07/teacher-training-courses.jpg"
                        },
                        new Course()
                        {
                            Name = "Digital Marketing Fundamentals",
                            Description = "The Digital Marketing Fundamentals course provides an overview of digital marketing strategies and techniques. You will learn about SEO, SEM, social media marketing, email marketing, and content marketing. Duration: 8 weeks.",
                            Price = 99.00,
                            StartDate = new DateTime(2024, 5, 15),
                            EndDate = new DateTime(2024, 9, 15),
                            CompanyId = 8,
                            CourseCategory = CourseCategory.Marketing,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRISngoG89cjQQ5X3qcKR6Def-8GmdXYUsP8w&s"
                        },
                        new Course()
                        {
                            Name = "Creative Writing Workshop",
                            Description = "The Creative Writing Workshop is designed for aspiring writers to develop their writing skills and explore different genres. You will receive constructive feedback on your writing and learn techniques to enhance your creativity. Duration: 6 weeks.",
                            Price = 79.00,
                            StartDate = new DateTime(2024, 8, 20),
                            EndDate = new DateTime(2024, 11, 20),
                            CompanyId = 9,
                            CourseCategory = CourseCategory.Writing,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMLX1XjOntMV2L9phhzGPCnG_AubOP5rdFgOftA9Z7nYWoIaxTrek_5kDvHSGsHoRWEW0&usqp=CAU"
                        },
                        new Course()
                        {
                            Name = "Photography Basics",
                            Description = "The Photography Basics course is designed for beginners to learn the fundamentals of photography. You will explore camera settings, composition techniques, lighting principles, and editing tools. Duration: 10 weeks.",
                            Price = 129.00,
                            StartDate = new DateTime(2024, 7, 5),
                            EndDate = new DateTime(2024, 10, 5),
                            CompanyId = 10,
                            CourseCategory = CourseCategory.Photography,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNUvA4Pt8VJXMpfTa8UY59R6bFeGvPhtSd62PSh6MrgHueNiE_QcPkWWeEhwkgGXoYubQ&usqp=CAU"
                        },
                        new Course()
                        {
                            Name = "Financial Planning",
                            Description = "The Financial Planning course covers personal finance topics such as budgeting, saving, investing, and retirement planning. You will learn how to set financial goals and make informed financial decisions. Duration: 8 weeks.",
                            Price = 109.00,
                            StartDate = new DateTime(2024, 9, 10),
                            EndDate = new DateTime(2024, 12, 10),
                            CompanyId = 11,
                            CourseCategory = CourseCategory.Finance,
                            ImageUrl = "https://money.usnews.com/dims4/USNEWS/0264e9e/17177859217e485cb0771b6e1529a77e/2147483647/format/jpg/quality/85/?url=https%3A%2F%2Fmoneydotcomvip.files.wordpress.com%2F2021%2F07%2Fgettyimages-1224166870.jpg"
                        },
                        new Course()
                        {
                            Name = "Artificial Intelligence Fundamentals",
                            Description = "The Artificial Intelligence Fundamentals course provides an introduction to AI concepts, algorithms, and applications. You will learn about machine learning, neural networks, natural language processing, and computer vision. Duration: 10 weeks.",
                            Price = 149.00,
                            StartDate = new DateTime(2024, 6, 25),
                            EndDate = new DateTime(2024, 10, 25),
                            CompanyId = 12,
                            CourseCategory = CourseCategory.Technology,
                            ImageUrl = "https://www.qualtrics.com/m/assets/wp-content/uploads/2022/08/classroom4.jpg"
                        }
                    });

                    context.SaveChanges();
                }


                if (!context.Teachers_Courses.Any())
                {
                    context.Teachers_Courses.AddRange(new List<Teacher_Course>()
                    {
                        new Teacher_Course()
                        {
                            TeacherId = 1,
                            CourseId = 1
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 2,
                            CourseId = 1
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 2,
                            CourseId = 2
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 1,
                            CourseId = 2
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 3,
                            CourseId = 3
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 6,
                            CourseId = 3
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 4,
                            CourseId = 4
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 5,
                            CourseId = 5
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 6,
                            CourseId = 6
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 3,
                            CourseId = 6
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 7,
                            CourseId = 7
                        },

                    });
                    context.SaveChanges();
                }
            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin",
                        UserName = "Admin",
                        ProfilePictureURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "User",
                        UserName = "User",
                        ProfilePictureURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
