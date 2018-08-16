using System;
using System.Collections.Generic;

namespace MazeOfTwistyTrampolines
{
    public class JumpInstructions
    {
        private readonly List<int> _offsets;
        private readonly Func<int> _onInstructionExecuted;

        public JumpInstructions(List<int> offsets, Func<int> onInstructionExecuted)
        {
            _offsets = offsets ?? throw new ArgumentNullException(nameof(offsets));
            _onInstructionExecuted = onInstructionExecuted ?? throw new ArgumentNullException(nameof(onInstructionExecuted));
        }

        public void Execute(Func<int, int> offsetMutator)
        {
            var index = 0;
            while (index >= 0 && index < _offsets.Count)
            {
                var offset = _offsets[index];
                _offsets[index] = offsetMutator(offset);

                index += offset;

                _onInstructionExecuted();
            }
        }
    }
}