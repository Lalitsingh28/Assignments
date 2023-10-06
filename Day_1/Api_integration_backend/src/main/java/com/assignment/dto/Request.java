package com.assignment.dto;

import java.util.ArrayList;
import java.util.List;

public class Request {

	private String model;
	private List<Message> messages;
	
	public Request() {
		// TODO Auto-generated constructor stub
	}

	public Request(String model, String prompt) {
		super();
		this.model = model;
		this.messages = new ArrayList<>();
		this.messages.add(new Message("user",prompt));
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
		
	}

	public List<Message> getMessages() {
		return messages;
	}

	public void setMessages(List<Message> messages) {
		this.messages = messages;
	}
	
	

	
}
