﻿/* 
 PureMVC C# Port by Andy Adamczak <andy.adamczak@puremvc.org>, et al.
 PureMVC - Copyright(c) 2006-08 Futurescale, Inc., Some rights reserved. 
 Your reuse is governed by the Creative Commons Attribution 3.0 License 
*/
using System;

using org.puremvc.csharp.interfaces;
using org.puremvc.csharp.patterns.command;

namespace org.puremvc.csharp.patterns.command
{
    /**
	 * A SimpleCommand subclass used by MacroCommandTestCommand.
	 *
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTest MacroCommandTest
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTestCommand MacroCommandTestCommand
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTestVO MacroCommandTestVO
	 */
    public class MacroCommandTestSub2Command : SimpleCommand
    {
        /**
		 * Constructor.
		 */
        public MacroCommandTestSub2Command()
            : base()
		{ }
		
		/**
		 * Fabricate a result by multiplying the input by itself
		 * 
		 * @param event the <code>IEvent</code> carrying the <code>MacroCommandTestVO</code>
		 */
		public override void execute(INotification note)
		{
			MacroCommandTestVO vo = note.getBody() as MacroCommandTestVO;
			
			// Fabricate a result
			vo.result2 = vo.input * vo.input;
		}
    }
}