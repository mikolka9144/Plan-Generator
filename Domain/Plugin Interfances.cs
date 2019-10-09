
namespace Domain
{
    public interface IPlanPlugin
    {
        bool IsLessonPlaceValid(Plan actualPlan,(int x,int y) lessonNewPositon,
            (int x,int y) planSize,Lesson lessonToPlace);
    }
}
