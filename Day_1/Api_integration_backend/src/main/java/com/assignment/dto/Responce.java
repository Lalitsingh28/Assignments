package com.assignment.dto;

import java.util.List;

public class Responce {
	
	private List<Choice> choices;
	
	
	public Responce() {
		// TODO Auto-generated constructor stub
	}
	
	
	
	public Responce(List<Choice> choices) {
		super();
		this.choices = choices;
	}



	public List<Choice> getChoices() {
		return choices;
	}



	public void setChoices(List<Choice> choices) {
		this.choices = choices;
	}



	public static class Choice{
		
		private int index;
		private Message message;
		public Choice(int index, Message message) {
			super();
			this.index = index;
			this.message = message;
		}
		
		public Choice() {
			// TODO Auto-generated constructor stub
		}

		public int getIndex() {
			return index;
		}

		public void setIndex(int index) {
			this.index = index;
		}

		public Message getMessage() {
			return message;
		}

		public void setMessage(Message message) {
			this.message = message;
		}
		
		
		
	}
	

}
