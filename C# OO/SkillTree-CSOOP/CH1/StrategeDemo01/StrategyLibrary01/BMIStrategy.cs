﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary01
{
    // // 使用策略上下文角色封裝, 隱藏 Strategy 的抽象
    internal abstract class BMIStrategy
    {
        //由屬性注入 Human, 封裝為 internal
        internal  Human Human
        { get; set; }

        protected Double _max;
        protected Double _min;
        private Double _bmi = 0;
        internal Double BMI
        {
            get
            {
                GetBMIValue();
                return _bmi;
            }
        }


        private string _result = string.Empty;
        internal String Result
        {
            get
            {
                GetBMIValue();
                GetResult();
                return _result;
            }
        }


        private void GetBMIValue()
        {
            if (Human.Weight > 0 && Human.Height > 0)
            { _bmi = Human.Weight / Math.Pow(Human.Height, 2); }
            else
            { _bmi = -1; }
        }

        private void GetResult()
        {
            if (BMI != -1)
            {
                if (BMI > _max)
                {
                    _result = "太胖";
                }
                else if (BMI < _min)
                {
                    _result = "太瘦";
                }
                else
                {
                    _result = "適中";
                }
            }
            else
            {
                _result = "體重或身高不得小於0";
            }
        }

    }

    internal class ManBMIStrategy : BMIStrategy
    {
        public  ManBMIStrategy()
        {
            _max = 25;
            _min = 20;
        }
    }

    internal class WomanBMIStrategy : BMIStrategy
    {
       public WomanBMIStrategy()
        {
            _max = 22;
            _min = 18;
        }
    }

    // 使用策略上下文角色封裝, 隱藏 Factory
    internal class StrategyFactory
    {
        public static BMIStrategy GetStrategy(Human human)
        {
            Type type = StrategyHelper.GetStrategyType(human.Gender);
            BMIStrategy strategy = (BMIStrategy)(Activator.CreateInstance(type));
            strategy.Human = human;
            return strategy;
        }
    }

public class BMIContext
{
    BMIStrategy _strategy;

    public BMIContext(Human human)
    {
        //封裝 Factory 建立實體的過程
        _strategy = StrategyFactory.GetStrategy(human);
    }

    public Double BMI
    {
        get { return _strategy.BMI; }
    }

    public String Result
    {
        get { return _strategy.Result;}
    }
}
}
