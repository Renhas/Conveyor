using Permutations;
using ConveyorSystem;

namespace Timetable
{
    public struct Result
    {
        public Permutation<Job> Permutation;
        public int Criterion;
        public Result(Permutation<Job> permutation, int criterion) 
        {
            Permutation = permutation;
            Criterion = criterion;
        }
    }
}
