using ComplexAlgebra;

namespace Calculus
{
    /// <summary>
    /// A calculator for <see cref="Complex"/> numbers, supporting 2 operations ('+', '-').
    /// The calculator visualizes a single value at a time.
    /// Users may change the currently shown value as many times as they like.
    /// Whenever an operation button is chosen, the calculator memorises the currently shown value and resets it.
    /// Before resetting, it performs any pending operation.
    /// Whenever the final result is requested, all pending operations are performed and the final result is shown.
    /// The calculator also supports resetting.
    /// </summary>
    ///
    /// HINT: model operations as constants
    /// HINT: model the following _public_ properties methods
    /// HINT: - a property/method for the currently shown value
    /// HINT: - a property/method to let the user request the final result
    /// HINT: - a property/method to let the user reset the calculator
    /// HINT: - a property/method to let the user request an operation
    /// HINT: - the usual ToString() method, which is helpful for debugging
    /// HINT: - you may exploit as many _private_ fields/methods/properties as you like
    ///
    /// TODO: implement the calculator class in such a way that the Program below works as expected
    class Calculator
    {
        public const char OperationPlus = '+';
        public const char OperationMinus = '-';
        private const char VOID_OPERATOR = ' ';

        // TODO fill this class
        public Complex _res;
        private char _lastOp;
        private char _operation;
        
        public Complex Value { get; set;}
        public char Operation 
        { 
            get => _operation;
            set
            {
                _lastOp = _operation;
                if (_res == null)
                {
                    _res = Value;
                }
                else if (_lastOp == OperationPlus)
                {
                    _res = _res.Plus(Value);
                }
                else if(_lastOp == OperationMinus)
                {
                    _res = _res.Minus(Value);
                }
                Value = null;
                _operation = value;
            }
        }

        public Calculator()
        {
            Value=null;
            _operation=VOID_OPERATOR;
        }

        public void ComputeResult()
        {
            if (Operation == OperationPlus)
            {
                _res = _res.Plus(Value);
            }
            else if(Operation == OperationMinus)
            {
                _res = _res.Minus(Value);
            }
            Value = _res;
        }

        public void Reset()
        {
            _res = null;
            Value = null;
            Operation = VOID_OPERATOR;
        }

        public override string ToString()
        {
            var value = Value == null ? "null" : Value.ToString();
            var operation = Operation == VOID_OPERATOR ? "null" : $"{Operation}";
            return $"{value}, {operation}"; 
        }
    }
}